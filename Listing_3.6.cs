using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменные: количество слагаемых, индексная
            // переменная и значение суммы:

            int n = 10, k = 1, s = 0;

            // Отображение сообщения:

            Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

            // Использование метки:

            mylabel:

            // Добавляем слагаемое в сумму:

            s += 2 * k - 1;

            // Изменение значения индексной переменной:

            k ++;

            // Использование инструкции goto:

            if (k <= n) goto mylabel; // Переход к помеченному коду

            // Отображение результата вычислений;

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
