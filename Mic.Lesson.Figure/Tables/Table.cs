using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Tables
{
    class Table:Shapes.Shape, IDrawable
    {
        public Table()
        {
            Row = 8;
            Column = 10;
            Color = Console.ForegroundColor;
        }

        public byte Row { get; set; }

        public byte Column { get; set; }
       
        public override int Area()
        {
            return Row * Column;
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Row; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < Column; j++)
                    {
                        Console.Write(" --  ");
                    }
                }
                Console.WriteLine();
                for (int g = 0; g < Column; g++)
                {
                    Console.Write("|  | ");
                }
                Console.WriteLine();
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(" --  ");
                }
            }
            Console.WriteLine();
            Console.ResetColor();
        }

       
    }
}
