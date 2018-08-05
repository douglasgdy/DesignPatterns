using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class Canvas
    {
        public const int MaxRow = 10;
        public const int MaxColumn = 10;
        private static readonly string[,] _coordinates = new string[MaxRow, MaxColumn];

        public void Draw(IPositionable element, int row, int column)
        {
            _coordinates[row, column] = element.Content;
        }

        public void Print()
        {
            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxColumn; j++)
                {
                    Console.WriteLine("[{0},{1}] = {2}", i, j, _coordinates[i, j]);
                }
            }
        }
    }
}
