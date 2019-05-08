using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] i = new int[ ] {{3, 4},{1, 0},{2, 1}};
            int b,j;
            for (b = 0; b < 10; b++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(i[b,j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
