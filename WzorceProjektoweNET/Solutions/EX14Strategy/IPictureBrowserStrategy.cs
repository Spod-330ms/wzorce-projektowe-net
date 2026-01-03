using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14Strategy
{
    public interface IPictureBrowserStrategy
    {
        public List<string> SearchPicture(string searchText);
    }
}
