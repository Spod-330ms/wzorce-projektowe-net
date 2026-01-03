using EX11Flyweight.Textures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11Flyweight
{
    public class TextureFactory
    {
        //Class for managing flyweight textures
        private Dictionary<string, AbstractTexture> _textures = new Dictionary<string, AbstractTexture>();
        private string _groundTextureFileName = "GroundTexture.png";
        private string _wallTextureFileName = "WallTexture.png";

        public AbstractTexture GetTexture(string textureName)
        {
            AbstractTexture texture = null;
            if (_textures.ContainsKey(textureName)) //If we've already created an instance of the requested texture, just use that.
            {
                texture = _textures[textureName];
            }
            else //Otherwise, create a brand new texture instance.
            {
                switch (textureName)
                {
                    case "Ground":
                        texture = new GroundTexture(this._groundTextureFileName);
                        break;
                    case "Wall":
                        texture = new WallTexture(this._wallTextureFileName);
                        break;
                    default:
                        throw new ArgumentException("Texture type not recognized.");
                }
                _textures.Add(textureName, texture);
            }
            return texture;
        }

        public void PrintTextures()
        {
            Console.WriteLine("Current textures in factory:");
            foreach (var textureEntry in _textures)
            {
                Console.WriteLine($"- {textureEntry.Key}: {textureEntry.Value.Path}");
            }
        }
    }
}
