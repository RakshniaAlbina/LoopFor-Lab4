using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите целое число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <=2*N-1; n+=2)
            {
                Console.WriteLine( sum += n);
            }
            Console.WriteLine("Квадрат числа {0} равен {1}", N, sum ); 
            Console.ReadKey();
        }
    }
}
