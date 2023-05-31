// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 1000 == num % 100)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}