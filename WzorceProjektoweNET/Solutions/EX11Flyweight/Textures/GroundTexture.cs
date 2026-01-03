using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11Flyweight.Textures
{
    public class GroundTexture : AbstractTexture
    {
        public GroundTexture(string path) : base(path)
        {
        }

        public override void Load()
        {
            //Fake load of texture data
            Width = 512;
            Height = 512;
            this._data = new byte[Width * Height * 4];

            Console.WriteLine($"Ground texture loaded from {Path} with size {Width}x{Height}"); 
        }
    }
}
