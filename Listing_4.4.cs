using System;

namespace Listing_4._4
{
    class CopyArrayDemo
    {
        static void Main()
        {
            // Целочисленный массив:
            int[] A = { 1, 3, 5, 7, 9 };

            // Переменные массива:
            int[] B, C;

            // Присваивание массивов:
            B = A;

            // Создание нового массива:
            C = new int[A.Length];

            // Поэлементное копирование массива:
            for(int k = 0; k<A.Length; k++)
            {
                C[k] = A[k];
            }

            // Изменение значения первого элемента в массиве А:
            A[0] = 0;

            // Изменение значения последнего элемента в массиве В:
            B[B.Length - 1] = 0;

            // Сообщение в консольном окне:
            Console.WriteLine("A: \tB: \tC:");

            // Отображение содержимого массивов:
            for(int k = 0; k<A.Length; k++)
            {
                // Отображение значений элементов массивов:
                Console.WriteLine("{0} \t{1} \t{2}", A[k], B[k], C[k]);
            }

            Console.ReadKey();
        }
    }
}
