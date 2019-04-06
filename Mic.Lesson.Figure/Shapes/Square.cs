using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Shapes
{
    class Square:Shape
    {
        public Square()
        {
            Width = 10;
        }
        public override void Draw()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The size of square is equal {Width}!");
            Console.ResetColor();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

        }
        public override int Area()
        {
            return Width * Width;
        }
    }
}
