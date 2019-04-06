using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Shapes
{
    class Rectangle: Shape
    {
        public Rectangle()
        {
            Height = 10;
        }
        public override int Area()
        {
            return Height * Width;
        }

        public override void Draw()
        {
            
            Console.WriteLine($"Additional info: The height of Rectangle is {Height} and width is {Height * 2}!");

            Width = (byte)(2*Height);

            for (int i = 0; i < Height; i++)
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

    }
}
