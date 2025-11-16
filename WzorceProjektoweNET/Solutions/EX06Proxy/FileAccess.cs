using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06Proxy
{
    public class FileAccess : IFileAccess
    {
        public void ReadFile(string fileName)
        {
            Console.WriteLine($"Reading file: {fileName}");
            // Simulate file reading operation
        }
    }
}
