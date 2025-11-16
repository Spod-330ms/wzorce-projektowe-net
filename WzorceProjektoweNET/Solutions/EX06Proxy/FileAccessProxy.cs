using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06Proxy
{
    public class FileAccessProxy : IFileAccess
    {
        private FileAccess _fileAccess = new FileAccess();
        private bool _isAuthenticated = false;
        public bool Authenticate(string username, string password)
        {
            // Simple authentication logic for demonstration purposes
            if (username == "admin" && password == "password")
            {
                _isAuthenticated = true;
                Console.WriteLine("Authentication successful.");
            }
            else
            {
                _isAuthenticated = false;
                Console.WriteLine("Authentication failed.");
            }

            return _isAuthenticated;
        }
        public void ReadFile(string fileName)
        {
            if (_isAuthenticated)
            {
                _fileAccess.ReadFile(fileName);
            }
            else
            {
                Console.WriteLine("Access denied. Please authenticate first.");
            }
        }
    }
}
