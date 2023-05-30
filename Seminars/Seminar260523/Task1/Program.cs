// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());

if(x / 1000 == x % 100)
System.Console.WriteLine("yes");
else
System.Console.WriteLine("no");