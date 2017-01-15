using System;
/// <summary>
/// Дано натуральное число N. Как наименьшим количеством монет можно выплатить N копеек.
/// Предполагается что в достаточном количестве имеются монеты достоинством 1, 2, 3, 4, 5, 10, 15, 20, 50 копеек.
/// </summary>
namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Count(n));
            Console.ReadLine();
        }

        private static int Count(int n)
        {
            int k = 0;
            if (n >= 50)
            {
                k += n / 50;
                n = n % 50;
            }
            if (n >= 20)
            {
                k += n / 20;
                n = n % 20;
            }
            if (n >= 15)
            {
                k += n / 15;
                n = n % 15;
            }
            if (n >= 10)
            {
                k += n / 10;
                n = n % 10;
            }
            if (n >= 5)
            {
                k += n / 5;
                n = n % 5;
            }
            if (n == 4)
            {
                k += n / 4;
                n = n % 4;
            }
            if (n == 3)
            {
                k += n / 3;
                n = n % 3;
            }
            if (n == 2)
            {
                k += n / 2;
                n = n % 2;
            }
            if (n == 1)
            {
                k += n / 1;
            }
            return k;
        }
    }
}
