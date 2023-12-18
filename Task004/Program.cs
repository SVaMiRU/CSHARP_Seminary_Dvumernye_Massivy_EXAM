// Задача 4: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

using System;

class Program
{
    static void Main()
    {
        int[,] array = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        int minElement = array[0, 0];
        int minRowIndex = 0;
        int minColumnIndex = 0;

        // Находим наименьший элемент массива и его индексы
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRowIndex = i;
                    minColumnIndex = j;
                }
            }
        }

        // Создаем новый массив без выбранной строки и столбца
        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
        int newRow = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i == minRowIndex)
            {
                continue;
            }

            int newColumn = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == minColumnIndex)
                {
                    continue;
                }

                newArray[newRow, newColumn] = array[i, j];
                newColumn++;
            }

            newRow++;
        }

        // Выводим новый массив
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
