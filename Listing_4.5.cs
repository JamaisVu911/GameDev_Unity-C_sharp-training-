using System;

namespace Listing_4._5
{
    class Program
    {
        static void Main()
        {
            // Переменные для записи значения элемента и индекса:
            int value, index;

            // Размер массива:
            int size = 15;

            // Объект для генерирования случайных чисел:
            Random rnd = new Random();

            // Создание массива:
            int[] nums = new int[size];

            // Заполнение и отображение массива:
            for(int k=0; k<nums.Length; k++)
            {
                // Значение элемента массива:
                nums[k] = rnd.Next(1, 101);

                // Отображение значение элемента:
                Console.Write(nums[k] + " ");
            }

            Console.WriteLine();

            // Поиск наибольшего элемента:
            index = 0;           // Начальное значение для индекса
            value = nums[index]; // Значение элемента с индексом

            // Перебор элементов:
            for(int k = 1; k < nums.Length; k++)
            {
                // Если значение проверяемого элемента больше текущего наибольшего значения:
                if (nums[k] > value)
                {
                    value = nums[k];   // Новое наибольшее значение
                    index = k;         // Новое значение для индекса
                }

            }

            // Отображение результата:
            Console.WriteLine("Наибольшее значение: " + value);
            Console.WriteLine("Индекс элемента: " + index);
            Console.ReadKey();


        }
    }
}
