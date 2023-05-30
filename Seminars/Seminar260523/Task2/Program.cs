// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координату X1");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist(int x1, int y1, int x2, int y2, int z1, int z2)
{
    int result = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);

    double res = Math.Sqrt(result);
    System.Console.WriteLine(res);
    return res;
}
dist(x1, y1, x2, y2, z1, z2);