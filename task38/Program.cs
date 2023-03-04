// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
}

void PrintArray(double[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.Write("]");
}

void FindDifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    Console.Write($" -> {Math.Round(max - min, 2)}");
}

double[] array = new double[5];
FillArray(array);
PrintArray(array);
FindDifferenceMaxMin(array);

