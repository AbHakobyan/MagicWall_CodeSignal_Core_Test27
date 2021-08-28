using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWall_CodeSignal_Core_Test27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = magicalWell(5, 6, 4);
            Console.WriteLine(n);
        }


        static int magicalWell(int a, int b, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++, a++, b++)
            {
                count += a * b;
            }
            return count;
        }
    }
}
