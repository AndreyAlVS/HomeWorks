// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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
    System.Console.WriteLine();
}


int Min(int[] array)
{
    int mini = array[0];
    int indexMini = 0;

    for (int i = 1; i < array.Length; i++)
        if (mini > array[i])
        {
            mini = array[i];
            indexMini = i;
        }
    System.Console.WriteLine($"Индекс минимального элемента массива равно: {indexMini}");
    System.Console.WriteLine($"минимальное значение массива равно: {mini}");
    System.Console.WriteLine();
    return indexMini;
}


int Max(int[] array)
{
    int maxi = array[0];
    int indexMax = 0;

    for (int i = 1; i < array.Length; i++)
        if (maxi < array[i])
        {
            maxi = array[i];
            indexMax = i;
        }
    Console.WriteLine($"Индекс максимального элемента массива равно: {indexMax}");
    System.Console.WriteLine($"максимальное значение массива равно: {maxi}");
    System.Console.WriteLine();
    return indexMax;
}


int Aver(int[] array)
{
    int sum = 0;
    int average = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        average = sum / array.Length;
    }
    System.Console.WriteLine($"среднее арифметическое всех элементов равно: {average}");
    return sum;
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
Min(array);
Max(array);
Aver(array);
