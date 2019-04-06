using Mic.Lesson.Figure.Shapes;
using Mic.Lesson.Figure.Shapes.Lines;
using Mic.Lesson.Figure.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>
            {
                new Arrow(),
                new Line(),
                new DoubleArrow(),
                new Rectangle(),
                new Square(),
                new Triangle(),
                new Table()

            };

            foreach(var shape in shapes)
            {
                Print(shape);
            }
                Console.ReadLine();
        }

        public static void Print(Shape item)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"***{item.GetType().Name}***");
            Console.ResetColor();
            item.Draw();
            Console.WriteLine();
        }
    }
}
