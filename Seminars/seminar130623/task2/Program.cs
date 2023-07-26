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



// int[] QuickSort(int[] arr)
// {
//     if (arr.Length <= 1)
//     {
//         return arr;
//     }

//     else
//     {
//         int pivot = arr[0];
//         int count_left = 0;
//         int count_right = 0;
//         for (int i = 1; i < arr.Length; i++)
//         {   
//             if (arr[i] < pivot)
//             {
//                 count_left++;
//             }
//             else
//             {
//                 count_right++;
//             }
//         }
//         int[] left = new int [count_left];
//         int[] right = new int [count_right];
        
//         int num_left = 0;
//         int num_right = 0;
//         for (int i = 1; i < arr.Length; i++)
//         {   
//             if (arr[i] < pivot)
//             {
//                 left[num_left] = arr[i];
//                 num_left++;
//             }
//             else
//             {
//                 right[num_right] = arr[i];
//                 num_right++;
//             }
//         }
//         // int[] left = arr.Skip(1).Where(x => x < pivot).ToArray();
//         // int[] right = arr.Skip(1).Where(x => x >= pivot).ToArray();
//         // int result_size = left.Length + 1 + right.Length;
//         // int[] result_arr = new int[result_size];
//         // for (int i = 0; i < result_size; i++)
//         // {
//         //     result_arr[i]
//         // }
//         return QuickSort(left).Concat(new int[] { pivot }).Concat(QuickSort(right)).ToArray();

//     }
// }

// int[] arr = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5};
// int[] arr_result = QuickSort(arr);

// foreach (var item in arr_result)
// {
//     Console.Write($"{item} ");
// }

// def quick_sort(arr):
//     if len(arr) <= 1:
//         return arr
//     else:
//         pivot = arr[0]

//         left = [x for x in arr[1:] if x < pivot]
//         right = [x for x in arr[1:] if x >= pivot]

//         return quick_sort(left) + [pivot] + quick_sort(right)


// arr = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5]

// sorted_arr = quick_sort(arr)

// print(sorted_arr)