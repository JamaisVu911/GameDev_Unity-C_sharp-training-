using System;

namespace Listing_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объект для генерирования случайных чисел:
            Random rnd = new Random();

            // Размер массива и индексная переменная:
            int size = 10, k;

            // Создание символьного массива:
            char[] symbs = new char[size];

            // Отображение сообщения:
            Console.WriteLine("Массив случайных символов: ");

            // Заполнение массива случайными символами:
            for(k = 0; k < symbs.Length; k++)
            {
                // Значение элемента массива:
                symbs[k] = (char)('A' + rnd.Next(26));

                // Отображение значения элемента массива:
                Console.Write("| " + symbs[k] + " ");
            }
            Console.WriteLine("|");

            // Отображение сообщения:
            Console.WriteLine("Массив в обратном порядке: ");

            for( k = symbs.Length - 1; k >= 0; k--)
            {
                // Отображение значения для элемента массива:
                Console.Write("| " + symbs[k] + " ");
            }
            Console.WriteLine("|");
            Console.ReadKey();
        }
    }
}
