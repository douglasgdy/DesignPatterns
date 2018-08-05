using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class Image : IPositionable
    {
        public Image(string fileName)
        {
            this.FileName = fileName;
            Console.WriteLine($"Create image from file {fileName}");
            string ext = Path.GetExtension(fileName).ToLower();
            if (ext == ".png")
            {
                this.ImageType = ImageType.Png;
                this.Content = $"{ImageType.Png} image content from file {fileName}";
            }
            if (ext == ".jpg")
            {
                this.ImageType = ImageType.Jpg;
                this.Content = $"{ImageType.Jpg} image content from file {fileName}";
            }
            if (ext == ".jpeg")
            {
                this.ImageType = ImageType.Jpeg;
                this.Content = $"{ImageType.Jpeg} image content from file {fileName}";
            }
            if (ext == ".bmp")
            {
                this.ImageType = ImageType.Bmp;
                this.Content = $"{ImageType.Bmp} image content from file {fileName}";
            }
            if (ext == ".gif")
            {
                this.ImageType = ImageType.Gif;
                this.Content = $"{ImageType.Gif} image content from file {fileName}";
            }
        }

        public string FileName { get; }
        public ImageType ImageType { get; }
        public string Content { get; }

        public void Draw(Canvas canvas, int row, int column)
        {
            canvas.Draw(this, row, column);
        }
    }

    public enum ImageType
    {
        None, Jpg, Jpeg, Png, Bmp, Gif
    }
}
