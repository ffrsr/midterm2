using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;

            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if(Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }

            dx /= step;
            dy /= step;
            x = x1;
            y = y1;

            int i = 1; 

            if(i <= step)
            {
                x += dx;
                y += dy;
                i++;
                Console.WriteLine("{0}, {1}",x,y);
            }
            else
            {

            }
            Console.ReadLine();

        }
    }
}
