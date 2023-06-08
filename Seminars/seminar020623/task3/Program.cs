// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * 1000;
}

void PrintArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"{Math.Round(item, 1)} ");
    System.Console.WriteLine();
    System.Console.WriteLine();
}

double Min(double[] array)
{
    double minimum = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    return Math.Round(minimum, 1, MidpointRounding.ToEven);
}

double Max(double[] array)
{
    double maximum = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
    return maximum;
}


double[] array = new double[5];
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"минимальное значение массива равно: {Min(array)}");
System.Console.WriteLine($"максимальное значение массива равно: {Max(array):f1}");
System.Console.WriteLine($"разница между максимальным и минимальным элементом массива равна: {Max(array) - Min(array):f1}");

