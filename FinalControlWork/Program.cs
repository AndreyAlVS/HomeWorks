// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void ReducedArr(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    Console.WriteLine(($"Отредактированный массив: [{string.Join(", ", array2)}]"));
}

int Array2Length(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
string[] array1 = new string[9] {"I", "will", "pass", "the", "final", "test", "with", "excellent", "marks" };
Console.WriteLine($"Начальный массив: [{string.Join(", ", array1)}]");
string[] array2 = new string[Array2Length(array1)];
ReducedArr(array1, array2);











