using System;

namespace Listing_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Количество строк и столбцов в массиве:
            int rows = 3, cols = 5;

            // Создание двумерного массива:
            int[,] nums = new int[rows, cols];

            // Значение первого элемента в массиве:
            int value = 1;

            // Заполнение и отображение массива
            // Перебор строк в массиве:
            for(int i = 0; i < nums.GetLength(0); i++)
            {
                // Перебор столбцов в строке:
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    // Присваивание значения элементу массива:
                    nums[i, j] = value;

                    // Это будет значение следующего элемента:
                    value++;

                    // Отображение элемента в строке:
                    Console.Write(nums[i, j] + "\t");
                }

                // Переход к новой строке:
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
