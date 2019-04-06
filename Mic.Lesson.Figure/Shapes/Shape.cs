using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Shapes
{
    abstract class Shape:IDrawable
    {
        public virtual byte Width { get; set; }
        public virtual byte Height { get; set; }
        public virtual ConsoleColor Color { get; set; }

        public Shape()
        {
            Color = Console.ForegroundColor;
        }

        public abstract void Draw();
        public abstract int Area();
    }
}
