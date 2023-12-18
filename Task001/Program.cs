// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static void Main()
    {
        int[,] array = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        
        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите номер столбца: ");
        int column = Convert.ToInt32(Console.ReadLine());
        
        // Проверка, что позиция валидная
        if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        {
            Console.WriteLine($"Значение в позиции ({row}, {column}) равно {array[row, column]}");
        }
        else
        {
            Console.WriteLine("Неверная позиция. В массиве нет элемента с такой позицией.");
        }
    }
}
