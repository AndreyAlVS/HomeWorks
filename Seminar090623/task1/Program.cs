// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

﻿// Задача 46: Задайте двумерный массив размером rows×cols, заполненный 
//случайными целыми числами.
// rows = 3, cols = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble() * 1000;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3:f1}    ");
        System.Console.WriteLine();
    }
}




Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, cols];
FillArray(array);
PrintArray(array);