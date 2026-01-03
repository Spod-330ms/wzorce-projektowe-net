using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14Strategy.PictureBrowser
{
    public class PixabayBrowserStrategy : IPictureBrowserStrategy
    {
        public List<string> SearchPicture(string searchText)
        {
            //Pixabay failed to sign in
            return new List<string> { "Pixabay picture 1 about " + searchText, "Pixabay picture 2 about " + searchText, "Pixabay picture 3 about " + searchText };
        }
    }
}
