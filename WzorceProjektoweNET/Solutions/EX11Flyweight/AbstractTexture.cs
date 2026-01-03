using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11Flyweight
{
    public abstract class AbstractTexture
    {
        public string Path { get; private set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        protected byte[]? _data;

        public AbstractTexture(string path)
        {
            Path = path;
        }

        public abstract void Load();
        public byte[] GetData()
        {
            if (_data == null)
            {
                throw new InvalidOperationException("Texture data not loaded. Call Load() first.");
            }
            return _data;
        }
    }
}
