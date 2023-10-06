using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCircle();
            Console.ReadLine();
        }

        static void PrintCircle()
        {
            int radius = 15;
            double x = radius;
            double y = radius;

            for(int i = -radius; i <= radius; i++)
            {
                for(double j = -radius; j <= radius; j++)
                {
                    double temp = Math.Pow(i / x, 2) + Math.Pow(j / y, 2);
                    if(temp > 0.05 && temp < 0.9)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
