// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.
System.Console.WriteLine("N-мерное пространство");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{
    System.Console.WriteLine($"Введите координату X{count}");
    int x = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Введите координату Y{count}");
    int y = Convert.ToInt32(Console.ReadLine());
    count++;
}



int count2 = 0;
while (count2 <= N)
{
    double dist(int x, int y)
    {
        int result = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);

        double res = Math.Sqrt(result);
        System.Console.WriteLine(res);
        return res;
    }
}
dist(x1, y1, x2, y2);