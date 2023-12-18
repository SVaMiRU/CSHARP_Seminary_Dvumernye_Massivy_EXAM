// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {
        int[,] array = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {10, 11, 12}};
        int minSum = int.MaxValue;
        int minSumRowIndex = 0;

        // Находим строку с наименьшей суммой элементов
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        // Выводим строку с наименьшей суммой элементов
        Console.WriteLine($"Строка с наименьшей суммой элементов находится в позиции {minSumRowIndex}");
    }
}
