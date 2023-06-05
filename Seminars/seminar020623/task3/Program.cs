// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


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

int Min(int[] array)
{
    int minimum = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    System.Console.WriteLine($"минимальное значение массива равно: {minimum}");
    return minimum;
}

int Max(int[] array)
{
    int maximum = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
    System.Console.WriteLine($"максимальное значение массива равно: {maximum}");
    return maximum;
}
// int diff = Max - Min;
// System.Console.WriteLine($"разница между максимальным и минимальным элементом массива равна: {diff}");

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Min(array);
Max(array);






int Min(int[] array)
{
    int minimum = array[0];
    for (int i = 1; i < array.Length; i++)
        if (...)
        {
            ...;
        }
    return minimum;
}

int Max(int[] array)
{
    int maximum = array[0];
    for (int i = 1; i < array.Length; i++)
        if (...)
        {
            ...;
        }
    return maximum;
}

int diff = Min - Max;