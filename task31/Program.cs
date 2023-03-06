// Задача 31.
// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных чисел равна -20.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)    //(int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)    //(int i = 0; i < size; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


int GetSumPositivElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}


int GetSumNegativeElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}


int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int sumPositiveElem = GetSumPositivElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма положительных чисел массиа = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных чисел массиа = {sumNegativeElem}");




// int[] GetSumPositiveNegativeElem(int[] arr)   //через массив
// {
//     int sumNegative = 0;
//     int sumPositive = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sumNegative += arr[i];
//         else sumPositive += arr[i];
//     }
//     return new int[] {sumNegative, sumPositive};
// }


// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();
// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);  // через массив
// Console.WriteLine($"Сумма положительных чисел массиа = {sumPositiveNegativeElem[1]}");  // через массив
// Console.WriteLine($"Сумма отрицательных чисел массиа = {sumPositiveNegativeElem[0]}");  // через массив