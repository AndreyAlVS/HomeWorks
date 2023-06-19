// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string SummaRec(int N)
{
    if (N == 0) return string.Empty;
    else return N + $", {SummaRec(N-1)}";
}


System.Console.WriteLine("Введите целое число ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SummaRec(N));
