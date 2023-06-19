// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Aquaman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Aquaman(m - 1, 1);
    else return Aquaman(m - 1, Aquaman(m, n - 1));
}

System.Console.WriteLine("Введите целое число ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($" A(m,n) = {Aquaman(m, n)}");


