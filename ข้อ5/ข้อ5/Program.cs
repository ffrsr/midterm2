using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int DayofWeek = int.Parse(Console.ReadLine());
            int TimeofDay = int.Parse(Console.ReadLine());

            string Menu = Console.ReadLine();

            bool breakfast = false;
            bool weekend = false;
            bool coffee = false;


            Console.ReadLine();

            do
            {
                string Menu1;
                Menu1 = Menu;
                for (int i = 1; i <= 5; i++)
                {
                    
                    if (Menu1 == "Breakfast Set") ;
                    {
                        breakfast = true;
                    }

                }

                for (int i = 1; i <= 2; i++)
                {
                    
                    if (Menu1 == "Weekend Set") ;
                    {
                        weekend = true;
                    }

                }
                for (int i = 1; i <= 3; i++)
                {
                    
                    if (Menu1 == "Coffee") ;
                    {
                        coffee = true;
                    }
                }
            } while (Menu == "End");

        }

       
    }
}
