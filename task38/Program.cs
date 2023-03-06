// Задача 38.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}


void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1)},   ");
        else Console.Write($"{Math.Round(arr[i], 1)}");
    }
    Console.Write("]");
}


double MaxElementsArray(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum) maxNum = arr[i];
    }
    return maxNum;
}


double MinElementsArray(double[] arr)
{
    double minNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum) minNum = arr[i];
    }
    return minNum;
}


double DifferenceMaxMinElementsArray(double maxElementsArray, double minElementsArray)
{
    double differenceMaxMinElementsArray = maxElementsArray - minElementsArray;
    return differenceMaxMinElementsArray;
}


double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(array);
Console.WriteLine();

double maxElementsArray = Math.Round(MaxElementsArray(array), 1);
double minElementsArray = Math.Round(MinElementsArray(array), 1);

double differenceMaxMinElementsArray = Math.Round(DifferenceMaxMinElementsArray(maxElementsArray, minElementsArray), 1);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {differenceMaxMinElementsArray}");