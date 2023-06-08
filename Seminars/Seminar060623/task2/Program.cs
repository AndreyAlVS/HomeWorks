// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


double findX(double[] array)
{
    double x = 0;
    {
        x = (array[2] - array[0]) / (array[1] - array[3]);
    }
    return x;
}


double FindY(double[] array)
{
    double y = 0;
    {
        y = (array[1] * (array[2] - array[0])) / (array[1] - array[3]) + array[0];
    }
    return y;
}

System.Console.WriteLine("Введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] array = new double[4];
array[0] = b1;
array[1] = k1;
array[2] = b2;
array[3] = k2;
System.Console.WriteLine($"Координата точки пересечения X: {findX(array):f1} Y: {FindY(array):f1}");

