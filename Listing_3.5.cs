using System;

namespace Listing_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Количество слагаемых в сумме, индексная
            // переменная и значение суммы:

            int n = 10, k, s = 0;

            // Отображение сообщения:

            Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

            // Оператор цикла:

            for(k = 1; k <= n; k++)
            {
                s += 2 * k - 1; // Добавляем слагаемое в сумму
            }

            // Отображение вычисленного значения;

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
