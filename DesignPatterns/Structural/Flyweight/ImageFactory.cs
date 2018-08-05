using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class ImageFactory
    {
        private readonly Dictionary<string, Image> _images =
            new Dictionary<string, Image>();

        public Image GetImage(string fileName)
        {
            if (!this._images.TryGetValue(fileName, out var image))
                image = this._images[fileName] = new Image(fileName);
            return image;
        }
    }
}
