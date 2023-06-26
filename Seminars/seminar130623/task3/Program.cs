// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}


int[,] prodMassive(int[,] Massiv1, int[,] Massiv2)
{
    int[,] massiv3 = new int[Massiv1.GetLength(0), Massiv2.GetLength(1)];

    for (int i = 0; i < Massiv1.GetLength(0); i++)
    {
        for (int j = 0; j < Massiv2.GetLength(1); j++)
        {
            for (int k = 0; k < Massiv1.GetLength(1); k++)
            {
                massiv3[i, j] += Massiv1[i, k] * Massiv2[k, j];
            }

        }
    }
    return massiv3;
}

System.Console.Write("Введите количество строк матрицы A: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов матрицы A: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество строк матрицы B: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов матрицы B: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows2, columns2];


FillArray(matrix1);
FillArray(matrix2);
System.Console.WriteLine($"matrix A");
PrintArray(matrix1);
System.Console.WriteLine($"matrix B");
PrintArray(matrix2);
System.Console.WriteLine($"matrix C");
PrintArray(prodMassive(matrix1, matrix2));
