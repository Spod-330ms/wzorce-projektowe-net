using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EX05Facade
{
    public class WeatherFacade
    {
        private string _apiKey;
        private string _apiWeatherQueryUrl = "https://api.openweathermap.org/data/3.0/onecall?lat={lat}&lon={lon}&exclude={part}&units=metric&appid={API key}";
        private Dictionary<string, Dictionary<string, string>> _cityPosition = new Dictionary<string, Dictionary<string, string>>()
        {
            {"London", new Dictionary<string, string>{{"lat", "51.5074"},{"lon", "-0.1278"}}},
            {"New York", new Dictionary<string, string>{{"lat", "40.7128"},{"lon", "-74.0060"}}},
            {"Tokyo", new Dictionary<string, string>{{"lat", "35.6895"},{"lon", "139.6917"}}},
            {"Warsaw", new Dictionary<string, string>{{"lat", "52.2297"},{"lon", "21.0122"}}}
        };
        public Dictionary<string, Dictionary<string, string>> CityPosition { get { return _cityPosition; } }
        public WeatherFacade(string apiKey)
        {
            _apiKey = apiKey;
        }

        public string GetCurrentWeather(string city)
        {
            if (!_cityPosition.ContainsKey(city))
            {
                throw new ArgumentException("City not found in the database.");
            }
            var position = _cityPosition[city];
            string lat = position["lat"];
            string lon = position["lon"];
            string url = _apiWeatherQueryUrl.Replace("{lat}", lat)
                                            .Replace("{lon}", lon)
                                            .Replace("{part}", "minutely,hourly,daily,alerts")
                                            .Replace("{API key}", _apiKey);
            // Here you would normally make an HTTP request to the URL and get the weather data.
            // For simplicity, we'll just return the constructed URL.

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var weatherData = response.Content.ReadAsStringAsync().Result;

            using JsonDocument doc = JsonDocument.Parse(weatherData);
            if (!doc.RootElement.TryGetProperty("current", out JsonElement current))
            {
                throw new InvalidOperationException("Brak pola 'current' w odpowiedzi API.");
            }

            if (!current.TryGetProperty("temp", out JsonElement tempElement))
            {
                throw new InvalidOperationException("Brak pola 'temp' w odpowiedzi API.");
            }

            double temp = tempElement.GetDouble();
            string generalWeather = current.GetProperty("weather")[0].GetProperty("description").GetString();

            return $"Current weather in {city}: {generalWeather}, Temperature: {temp}°C";
        }
    }


   
}
