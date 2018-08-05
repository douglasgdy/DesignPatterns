using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class Text : IPositionable
    {
        public Text(string content)
        {
            this.Content = content;
        }

        public string Content { get; }

        public void Draw(Canvas canvas, int row, int column)
        {
            canvas.Draw(this, row, column);
        }
    }
}
