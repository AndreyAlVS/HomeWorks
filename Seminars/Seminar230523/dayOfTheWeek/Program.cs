// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число от 1 до 7");
int x1 = int.Parse(System.Console.ReadLine()!);

if (x1 == 1 || x1 == 2 || x1 == 3 || x1 == 4 || x1 == 5)
{
    Console.WriteLine("Нет");
}
else
   Console.WriteLine("Да");
   