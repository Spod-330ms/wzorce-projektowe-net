using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14Strategy
{
    public class RedactionBrowser
    {
        private IPictureBrowserStrategy _pictureBrowser;

        public void SetBrowsingStrategy(IPictureBrowserStrategy pictureBrowser)
        {
            _pictureBrowser = pictureBrowser;
        }
        public List<string> FindPictures(string searchText)
        {
            return _pictureBrowser.SearchPicture(searchText);
        }
    }
}
