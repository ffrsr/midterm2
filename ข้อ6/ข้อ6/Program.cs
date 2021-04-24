using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ6
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= H*N; i++)
            {
            
                for (int j = 1; j <= H; j++)
                {
                    Console.Write(input);
                }
                
                Console.WriteLine(input);

                
            }
            
            Console.ReadLine();
        }
    }
}
