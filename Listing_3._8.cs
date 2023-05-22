using System;

namespace Listing_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива из 12 чисел:
            int[] nums = new int[12];

            // Перебор элементов массива:
            for(int k = 0; k < nums.Length; k++)
            {
                // Присваивание значения элементу массива:
                nums[k] = 3 * k + 1;

                // Отображение значения элемента массива:
                Console.Write(" | " + nums[k] + " ");
            }

            Console.WriteLine(" | ");
            Console.ReadKey();
        }
    }
}
