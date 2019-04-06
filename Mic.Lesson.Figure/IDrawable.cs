using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure
{
    interface IDrawable
    {
        void Draw();
        ConsoleColor Color { get; set; }
       // void Print();
    }
}
