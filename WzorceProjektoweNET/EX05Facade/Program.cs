using EX05Facade;
using DotNetEnv;
using System;
using System.IO;


//Pobranie klucza API z pliku .env - nie jest umieszczony w repozytorium
Env.Load(".env");
string API_key = Env.GetString("api_key") ?? throw new Exception("Brak klucza api_key");

WeatherFacade facade = new WeatherFacade(API_key);

// reszta programu bez zmian...
var cities = facade.CityPosition.Keys;
if (cities.Count == 0)
{
    Console.WriteLine("No cities found.");
    return;
}
else
{
    Console.WriteLine("Select cities to check the weather");

    foreach (var city in cities)
    {
        Console.WriteLine($"Weather data for {city}");
    }
    var selectedCity = Console.ReadLine();
    if (selectedCity != null && cities.Contains(selectedCity))
    {
        string weather = facade.GetCurrentWeather(selectedCity);
        Console.WriteLine(weather);
    }
    else
    {
        Console.WriteLine("City not found.");
    }
}

