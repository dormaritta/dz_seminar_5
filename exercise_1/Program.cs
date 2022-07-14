/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = new int[4];
int length = array.Length;
int count = 0;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100, 999);
}

foreach(int element in array)
{
    Console.Write("{0} ", element);
    if (element % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве: " +count);