// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummaRec(int M, int N)
{
    int sum = M;
    if (M > N) return 0;
    else return sum + SummaRec(M+1, N);
}

System.Console.WriteLine("Введите целое число ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SummaRec(M, N));