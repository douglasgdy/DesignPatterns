using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class Sample
    {
        public static void Start()
        {
            var files = new List<string>
            {
                @"C:\Projects\DesignPatterns\imge1.png",
                @"C:\Projects\DesignPatterns\imge2.jpg",
                @"C:\Projects\DesignPatterns\imge3.jpeg"
            };
            var chars = new List<string>
            {
                "a","b","c","d","11111"
            };
            var canvas = DrawOnCanvas(files, chars);
            canvas.Print();
        }

        public static Canvas DrawOnCanvas(List<string> imageFiles, List<string> texts)
        {
            var canvas = new Canvas();
            var factory = new ImageFactory();
            var r = new Random();
            for (int i = 0; i < Canvas.MaxRow; i++)
            {
                for (int j = 0; j < Canvas.MaxColumn; j++)
                {
                    bool loadImage = r.Next(100) % 2 == 0;
                    int imageIndex = r.Next(imageFiles.Count);
                    int textIndex = r.Next(texts.Count);
                    var element = loadImage
                        ? (IPositionable)factory.GetImage(imageFiles[imageIndex])
                        : new Text(texts[textIndex]);
                    element.Draw(canvas, i, j);
                }
            }
            return canvas;
        }
    }
}
