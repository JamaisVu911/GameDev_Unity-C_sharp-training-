using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Количество слагаемых в сумме, индексная
            // переменная и значение суммы:

            int n = 10, k = 1, s = 0;

            // Отображение сообщения:

            Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

            // Оператор цикла:

            do
            {
                s += 2 * k - 1; // Добавляем слагаемое в сумму

                k++;            // Новое значение индексной переменной
            }
            
            while (k <= n);

            // Отображение вычисленного значения;

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
