using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Shapes.Lines
{
    class Line : Shape
    {
        public Line()
        {
            Width = 10;
        }
        private byte _height;
        public sealed override byte Height
        {
            get => _height;
            set
            {
                _height = value;
                _width = 0;

            }
        }

        private byte _width;
        public sealed override byte Width
        {
            get => _width;
            set
            {
                _width = value;
                _height = 0;

            }
        }

        
        public bool IsVertical => _height != 0;
     
        public sealed override int Area()
        {
            return 0;
        }

        public override void Draw()
        {
            if(IsVertical)
            {
                for (int i = 0; i < _height; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("|");
                    Console.ResetColor();

                  
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(new string('-', _width));
                Console.ResetColor();
                
            }
        }


        
    }
}
