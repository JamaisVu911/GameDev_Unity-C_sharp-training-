using System;

namespace Listing_4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив из трех перемнных типа Object:
            Object[] objs = new Object[3];

            // Элементам массива присваиваются значения разных типов:
            objs[0] = 123;               // Целое число
            objs[1] = 'A';               // Символ
            objs[2] = "Третий элемент";  // Текст

            Console.WriteLine("Создан такой массив: ");

            // Проверка содержимого массива:
            for(int k = 0; k < objs.Length; k++)
            {
                Console.WriteLine(k + ": " +objs[k]);
            }

            // Новые значения элементов:
            objs[0] = (int)objs[0] + 111; // Целое число
            objs[1] = "Второй элемент";   // Текст
            objs[2] = 3.141592;           // Действительное число

            Console.WriteLine("После присваивания значений: ");

            // Проверка содержимого массива:
            for(int k = 0; k < objs.Length; k++)
            {
                Console.WriteLine(k + ": " + objs[k]);
            }

            // Целочисленный массив:
            int[] nums = { 10, 20, 30 };

            // Переменная массива присваивается как значение элементу массива:
            objs[2] = nums;
            Console.WriteLine("Целочисленный массив: ");

            // Отображение элементов целочисленного массива:
            for(int i = 0; i < ((int[]) objs[2]).Length; i++)
            {
                Console.Write("{0, 3}", ((int[])objs[2])[i]);
            }

            Console.WriteLine();

            // Новое значение элемента в числовом массиве:
            ((int[])objs[2])[1] = 0;
            
            Console.WriteLine("Еще раз тот же массив: ");
            
            // Отображение элементов целочисленного массива:
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0,3}", nums[i]);
            }

            Console.WriteLine();
        }
    }
}
