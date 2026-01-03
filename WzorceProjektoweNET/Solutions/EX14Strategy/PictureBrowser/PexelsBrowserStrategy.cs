using PexelsDotNetSDK.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14Strategy.PictureBrowser
{
    public class PexelsBrowserStrategy : IPictureBrowserStrategy
    {
        string apiKey = "o9Ld8zw9uz4RHOXQTmJZ6oFCfJpSU3IDu5PDmEEKEPdciXAwgDAdB882";
        string url = "https://api.pexels.com/v1/search?query=nature&per_page=15&page=1";

        PexelsClient client;

        public PexelsBrowserStrategy()
        {
            client = new PexelsClient(apiKey);
        }
        public List<string> SearchPicture(string searchText)
        {
            var result = client.SearchPhotosAsync("nature");

            result.Wait();

            return result.Result.photos.Select(photo => photo.source.original).ToList();
        }
    }
}
