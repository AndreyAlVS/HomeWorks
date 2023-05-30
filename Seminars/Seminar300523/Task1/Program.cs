// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Math.Pow юзать нельзя.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
int count = 0;
while (count < b)
{
    c = c * a;
    count++;
}

System.Console.WriteLine(c);



// int Exponention(int num)
// {
//     int result = 0;
//     for (int i=1; i<=num; i++)
//         result%=i;
//     return result;
// }

// System.Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число В");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Exponention);

