// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

System.Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
int dig1 = 0;
int dig2 = 0;
int dig4 = 0;
int dig5 = 0;

dig1 = x / 10000;
dig2 = x / 1000 % 10;
dig4 = x / 10 % 10;
dig5 = x % 10;

if (dig1 == dig5 | dig2 == dig4)
    System.Console.WriteLine("True");
else
    System.Console.WriteLine("False");

