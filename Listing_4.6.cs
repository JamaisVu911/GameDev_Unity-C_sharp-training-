using System;

namespace Listing_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Символьная переменная:
            char s;

            // Исходный символьный массив:
            char[] symbs = { 'Q', 'Ы', 'a', 'B', 'R', 'A', 'r', 'q', 'b' };

            // Отображение содержимого массива:
            Console.WriteLine("Массив до сортировки: ");
            
            for(int k = 0; k < symbs.Length; k++ )
            {
                Console.Write(symbs[k] + " ");
            }
            Console.WriteLine();

            // Сортировка элеметов в массиве:
            for(int i = 1; i < symbs.Length; i++)
            {
                // Перебор элементов:
                for(int j = 0; j < symbs.Length-i; j++)
                {
                    // Если значение элемента слева больше значения элемента справа:
                    if(symbs[j] > symbs[j+1])
                    {
                        s = symbs[j + 1];
                        symbs[j + 1] = symbs[j];
                        symbs[j] = s;
                    }
                }    
            }

            // Отображение содержимого массива:
            Console.WriteLine("Массив после сортировки: ");

            for(int k = 0; k < symbs.Length; k++)
            {
                Console.Write(symbs[k] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
