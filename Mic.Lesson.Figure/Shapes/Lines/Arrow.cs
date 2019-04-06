using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Figure.Shapes.Lines
{
    class Arrow:Line
    {
        public override void Draw()
        {
            base.Draw();
            if(IsVertical)
            {
                Console.WriteLine("V");
            }
            else
            {
                
                Console.Write(">");
            }

        }
    }
}
