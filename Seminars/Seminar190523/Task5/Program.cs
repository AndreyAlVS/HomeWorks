﻿// // Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности 
// и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// // 456111 -> 6
// // 78 -> нет
// // 9146548 -> 4
// // 3 -> нет

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());


while (num > 1000)
{
    num = num / 10;
    Console.Write(num % 10);
}

if (num > 1000)
{
    Console.Write(num % 10);
}