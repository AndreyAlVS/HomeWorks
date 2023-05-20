// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число3");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;


if (num1 > num2)
{
    Console.WriteLine(max);
}
else if (num2 > num3)
{
    max = num2;
    Console.WriteLine(max);
}
else if (num1 == num2 && num2 == num3)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine(num3);
}