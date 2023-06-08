// Задача VERY HARD необязательная 
// Имеется массив случайных целых чисел. 
// Создайте массив, в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. 
// Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        array[i] = new Random().Next(-10, 100);

}

void PrintArray(int[] array)
{
    foreach (var item in array)

        Console.Write($"{item}, ");
    System.Console.WriteLine();

}

int SumOddNumber(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sumOdd = sumOdd + array[i];
    }
    return sumOdd;
}


System.Console.WriteLine("Введите размерность массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
SumOddNumber(array);
System.Console.WriteLine(SumOddNumber(array));