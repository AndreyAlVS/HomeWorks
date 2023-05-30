// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int y = 0;
// while (count <= x)
// {
//     y = count * count * count;
//     // System.Console.WriteLine(y);
//     Console.Write($"{y}, ");
//     count++;
// }

int Cube(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
        result = i * i * i;
    return result;
}

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Cube(num));
