// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 0; num > 0; i++)
{
    sum = sum + num % 10;
    num = num / 10;
}
Console.WriteLine($"Сумма цифр равна: {sum}");


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (num > 0)
// {
//     sum = sum + num % 10;
//     num = num / 10;
// }

// Console.WriteLine($"Сумма цифр равна: {sum}");




// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int b = 0;
// int[] array = new int[count];
// while (count < x)
// {
//     b = x % 10;
//     array[0] = b;
//     count++;
//     // array++;
//     // System.Console.WriteLine(array);
// }
// System.Console.WriteLine(array);


