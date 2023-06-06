// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


// void FillArray(double[] array)
// {
//     for (double i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 1000);
// }

// void PrintArray(double[] array)
// {
//     foreach (var item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// double Min(double[] array)
// {
//     double minimum = array[0];
//     for (double i = 1; i < array.Length; i++)
//         if (array[i] < minimum)
//         {
//             minimum = array[i];
//         }
//     System.Console.WriteLine($"минимальное значение массива равно: {minimum}");
//     return minimum;
//     }

// double Max(double[] array)
// {
//     double maximum = array[0];
//     for (double i = 1; i < array.Length; i++)
//         if (array[i] > maximum)
//         {
//             maximum = array[i];
//             System.Console.WriteLine($"максимальное значение массива равно: {maximum}");
//         }
//     return maximum;
// }


// double[] array = new double[5];
// FillArray(array);
// PrintArray(array);
// Min(array);
// Max(array);
// double diff = Max(array) - Min(array);
// System.Console.WriteLine($"разница между максимальным и минимальным элементом массива равна: {diff}");



//DOUBLE


void FillArray(double[] array)
{
    for (double i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1000);
}

void PrintArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

double Min(double[] array)
{
    double minimum = array[0];
    for (double i = 1; i < array.Length; i++)
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    System.Console.WriteLine($"минимальное значение массива равно: {minimum}");
    return minimum;
    }

double Max(double[] array)
{
    double maximum = array[0];
    for (double i = 1; i < array.Length; i++)
        if (array[i] > maximum)
        {
            maximum = array[i];
            System.Console.WriteLine($"максимальное значение массива равно: {maximum}");
        }
    return maximum;
}


double[] array = new double[5];
FillArray(array);
PrintArray(array);
Min(array);
Max(array);
double diff = Max(array) - Min(array);
System.Console.WriteLine($"разница между максимальным и минимальным элементом массива равна: {diff}");



