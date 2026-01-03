using EX11Flyweight;

TextureFactory textureFactory = new TextureFactory();
AbstractTexture groundTexture1 = textureFactory.GetTexture("Ground");
AbstractTexture groundTexture2 = textureFactory.GetTexture("Ground");
AbstractTexture wallTexture1 = textureFactory.GetTexture("Wall");
AbstractTexture wallTexture2 = textureFactory.GetTexture("Wall");
Console.WriteLine($"Are groundTexture1 and groundTexture2 the same instance? {ReferenceEquals(groundTexture1, groundTexture2)}");

textureFactory.PrintTextures();
