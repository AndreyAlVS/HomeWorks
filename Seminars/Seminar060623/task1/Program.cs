// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int findPos(int[] array)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    if  (array[i]>0)
    {
        pos++;
    }
    return pos;
}



System.Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 3");
int num3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 4");
int num4 = Convert.ToInt32(Console.ReadLine());

int[] array = new int[4];
array[0] = num1;
array[1] = num2;
array[2] = num3;
array[3] = num4;
System.Console.WriteLine($"Пользователь ввёл {findPos(array)} числа больше нуля");
