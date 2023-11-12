using System;

namespace Listing_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание и инциализация двумерного массива:
            char[,] symbs = { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } };

            Console.WriteLine("Исходный массив: ");
            
            // Отображение массива:
            for(int i = 0; i < symbs.GetLength(0); i++)
            {
                for(int j = 0; j < symbs.GetLength(1); j++)
                {
                    Console.Write(symbs[i, j] + " ");
                }

                // Переход к новой строке:
                Console.WriteLine();
            }

            // Объект для генерирования случайных чисел:
            Random rnd = new Random();

            // Строка и столбец:
            int row = rnd.Next(symbs.GetLength(0) + 1);
            int col = rnd.Next(symbs.GetLength(1) + 1);

            Console.WriteLine(" Добавляется {0}-я строка и {1}-й столбец", row, col);

            // Создание нового массива:
            char[,] tmp = new char[symbs.GetLength(0) + 1, symbs.GetLength(1) + 1];

            // Целочисленные переменные:
            int a, b;

            // Символьная переменная:
            char s = 'a';

            // Заполнение массива. Копирование значений из исходного массива:
            for(int i =0; i < symbs.GetLength(0); i++)
            {
                // Первый индекс для элемента нового массива:
                if (i < row) a = i;
                else a = i + 1;

                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    // Второй индекс для элемента нового массива:
                    if (j < col) b = j;
                    else b = j + 1;

                    // Присваивание значения элементу массива:
                    tmp[a, b] = symbs[i, j];
                }
            }

            // Заполнение добавленной строки в новом массиве:
            for(int j = 0; j < tmp.GetLength(1); j++)
            {
                // Значение элемента в строке:
                tmp[row, j] = s;

                // Новое значение следующего элемента:
                s++;
            }    

            for(int i =0; i < tmp.GetLength(0); i++)
            {
                // Если значение не в добавленной строке:
                if(i != row)
                {
                    // Значение элемента в столбце:
                    tmp[i, col] = s;

                    // Новое значение для следующего элемента:
                    s++;
                }
            }

            // Присваивание массивов:
            symbs = tmp;
            Console.WriteLine("Новый массив: ");

            // Отображение массива:
            for(int i = 0; i < symbs.GetLength(0); i++)
            {
                for(int j = 0; j < symbs.GetLength(1); j++)
                {
                    // Отображение значение элемента:
                    Console.Write(symbs[i, j] + " ");
                }

                // Переход к новой строке:
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
