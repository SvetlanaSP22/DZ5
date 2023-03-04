// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);

}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el}, ");
    Console.Write("]");
}

int FindNumberOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

int[] array = new int[4];
FillArray(array);
PrintArray(array);
int count = FindNumberOfEvenNumbers(array);
Console.Write($" -> {count}");

// можно на выдачу данных записать эту строку - Console.Write($"Количество четных чисел в массиве равно {count}");