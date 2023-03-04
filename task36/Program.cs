﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);

}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el}, ");
    Console.Write("]");
}

int FindSumOfOddArrayElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            sum += array[i];
    return sum;
}



