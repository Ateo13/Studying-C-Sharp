using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Fibonacci2
    {
        /* Главный метод, выводит в консоль ряд Фибоначчи до 20 числа экспоненциально.
           The main method. It shows the fibonacci row.*/
        static void Main()
        {
            for (int j = 0; j < 20; j++)
                Console.WriteLine(Fibonachi(j));
        }
        // Метод, вычисляющий числа Фибоначчи. Method that makes Fibonacci raw.
        static int Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            int[] f = new int[n];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i < n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n - 1];
        }
    }
}
