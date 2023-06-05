// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1000);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int FindNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count = count + array[i];
    }
    return count;
}
Console.Clear();
int[] array = new int[5];
FillArray(array);
PrintArray(array);
FindNum(array);
System.Console.WriteLine(FindNum(array));


