using System;

namespace Listing_4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Символьный массив из переменных массива:
            char[][] symbs = new char[5][];

            // Целочисленный массив из переменных массива:
            int[][] nums = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } };

            // Символьная перемнная:
            char s = 'А';

            // Заполнение символьного массива.
            // Перебор элементов во внешнем массиве:
            for (int i = 0; i < symbs.Length; i++)
            {
                // Создание внутреннего массива:
                symbs[i] = new char[i + 3];

                // Перебор элементов во внутреннем массиве:
                for(int j = 0; j < symbs[i].Length; j++)
                {
                    // Значение элемента внутреннего массива:
                    symbs[i][j] = s;

                    // Значение для следующего элемента:
                    s++;
                }
            }

            Console.WriteLine("Целочисленный массив: ");

            // Отображение целочисленного массива:
            for( int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write("{0,3}", nums[i][j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Символьный массив: ");

            // Отображение символьного массива.
            // Перебор элементов внешнего массива:
            foreach(char[] q in symbs)
            {
                // Перебор элементов во внутреннем массиве:
                foreach (char p in q)
                {
                    // Отображение элемента массива:
                    Console.Write("{0,2}", p);
                }

                Console.WriteLine();

            }
        }
    }
}
