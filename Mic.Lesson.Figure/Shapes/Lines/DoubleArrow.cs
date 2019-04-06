using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Shapes.Lines
{
    class DoubleArrow:Arrow
    {
        public override void Draw()
        {
            if(IsVertical)
            {
                Console.WriteLine("^");
                base.Draw();
            }
            else
            {
                Console.Write("<");
               
                base.Draw();
            }
        }
    }
}
