using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11Flyweight.Textures
{
    public class WallTexture : AbstractTexture
    {
        public WallTexture(string path) : base(path)
        {
        }

        public override void Load()
        {
            //Fake load of texture data
            Width = 256;
            Height = 256;
            this._data = new byte[Width * Height * 4];

            Console.WriteLine($"Wall texture loaded from {Path} with size {Width}x{Height}");
        }
    }
}
