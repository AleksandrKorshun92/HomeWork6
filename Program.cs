﻿//Задача 41: Заполнение массива пользователем. 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*int[] InputMassiv(int size)
{
    int[] massiv = new int [size];
    for(int i = 0; i<massiv.Length; i++)
    {
        Console.WriteLine($"Напишите {i+1} число");
        massiv[i] = Convert.ToInt32(Console.ReadLine());
    }
    return massiv;
}

int CheckNumber(int[] massiv)
{
    int count = 0;
    for(int i=0; i < massiv.Length; i++)
    {
        if(massiv[i]>0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Напишите сколько цифр будет для проверки = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massiv = InputMassiv(size);
Console.WriteLine($"[{string.Join(",", massiv)}]");
Console.WriteLine($"количество цифр больше 0 = {CheckNumber(massiv)}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");