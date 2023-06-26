// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(15);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}

int[] StringSum(int[,] array)
{
    int[] Massiv = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Massiv[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Massiv[i] += array[i, j];

        }
    }
    return Massiv;
}

string ReturnString(int[] Massiv)
{
    int min = Massiv[0];
    int ind = 0;
    for (int i = 0; i < Massiv.Length; i++)
    {

        if (Massiv[i] < min)
        {
            min = Massiv[i];
            ind = i;
        }
    }
    return $"{ind + 1} строка";
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(string.Join(" ", StringSum(array)));
System.Console.WriteLine(ReturnString(StringSum(array)));

