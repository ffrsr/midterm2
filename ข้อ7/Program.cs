using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());  
            int b = int.Parse(Console.ReadLine());

            char input = char.Parse(Console.ReadLine());

            Console.ReadLine();

            if (input == '+' || input == '-' || input == '*' || input == '/')
            {
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
            }

            else if (input == '^')
            {
                int n = int.Parse(Console.ReadLine());
            }

            else if (input == '|')
            { }

            else { }
            
        }
    }
}
