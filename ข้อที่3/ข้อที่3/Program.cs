using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อที่3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float filmBackWidth;

            Console.ReadLine();

            do
            {
                filmBackWidth = float.Parse(Console.ReadLine());

                if (filmBackWidth > 0)
                {
                    float fLength, fov;

                    if (mode == "fLength")
                    {
                        fLength = float.Parse(Console.ReadLine());
                        do
                        {
                            if (fLength > 0)
                            {
                                fov = (float)(2 * Math.Atan(filmBackWidth / (2 * fLength)));
                                Console.WriteLine("fov = {0}", fov);
                            }
                            else
                            {
                                Console.WriteLine("Invalid fLength. Please input again.");
                            }
                        } while (fLength < 0);
                    }
                    else if (mode == "fov")
                    {
                        fov = float.Parse(Console.ReadLine());

                        do
                        {
                            if (fov > 0.1 && fov < 6.28)
                            {
                                fLength = (float)(filmBackWidth / (2 * Math.Tan(fov / 2)));
                                Console.WriteLine("fLegth = {0}", fLength);
                            }
                            else
                            {
                                Console.WriteLine("Invalid fov. Please input again.");
                            }
                        } while (fov < 0.1 && fov > 6.28);
                    }

                }

                else
                {
                    Console.WriteLine("Invalid filmBackWidth. Please input again.");
                }


            } while (filmBackWidth > 0);
        }
    }
}
