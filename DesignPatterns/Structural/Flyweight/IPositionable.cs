using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public interface IPositionable
    {
        string Content { get; }
        void Draw(Canvas canvas, int row, int column);
    }
}
