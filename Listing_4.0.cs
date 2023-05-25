using System;

namespace Listing_4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание и инициализация массивов:
            int[] nums = { 1, 3, 5, 7, 6, 5, 4 };
            char[] symbs = new char[] { 'A', 'Z', 'B', 'Y' };
            string[] txts = new string[3] { "один", "два", "три" };

            // Отображение содержимого массивов:
            Console.WriteLine("Массив nums: ");

            for(int k = 0; k < nums.Length; k++)
            {
                Console.Write(nums[k] + " ");
            }
            
            Console.WriteLine("\nМассив sumbs: ");

            for (int k = 0; k < symbs.Length; k++)
            {
                Console.Write(symbs[k] + " ");
            }

            Console.WriteLine("\nМассив txts: ");

            for (int k = 0; k < txts.Length; k++)
            {
                Console.Write(txts[k] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
