// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

using System;

class Program
{
    static void Main()
    {
        int[,] array = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        
        // Сохраняем первую строку во временный массив
        int[] temp = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            temp[i] = array[0, i];
        }
        
        // Переносим последнюю строку в первую
        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[0, i] = array[array.GetLength(0) - 1, i];
        }
        
        // Переносим временную строку в последнюю
        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[array.GetLength(0) - 1, i] = temp[i];
        }
        
        // Выводим измененный массив
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
