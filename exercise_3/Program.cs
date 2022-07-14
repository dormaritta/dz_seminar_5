﻿/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] array = new double[5];
double length = array.Length;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-99, 99);
    Console.Write($"{array[i]} ");
}

double max = array[0]; double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double diff = 0;
diff = max - min;

Console.WriteLine();
Console.WriteLine("Разница максимального и минимального значения: " +diff);