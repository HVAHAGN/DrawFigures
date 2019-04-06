using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Shapes
{
    class Triangle:Shape
    {
        public Triangle()
        {
            Width = 11;
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Count of Triangle's lines are ={Width}\n");
            Console.ResetColor();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width - (i + 1); j++)
                    Console.Write(" ");
                for (int j = 0; j < 2 * i + 1; j++)
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
            throw new NotImplementedException();
        }
    }
}
