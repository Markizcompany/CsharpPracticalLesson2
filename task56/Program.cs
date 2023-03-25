// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];  // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // colums
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}


int[] ArraySumRowsMatrix(int[,] matrix)
{
    int sizeRowsArray = matrix.GetLength(0);
    int sizeColumsArray = matrix.GetLength(1);
    int[] NewArray = new int[sizeRowsArray];
    int sum = 0;

    for (int i = 0; i < sizeRowsArray; i++)
    {
        for (int j = 0; j < sizeColumsArray; j++)
        {
            sum += matrix[i, j];
        }
        NewArray[i] = sum;
        sum = 0;
    }
    return NewArray;
}


void NumberRowsMinSumMatrix(int[] array)
{
    int minElem = array[0];
    int numberRowsMatrix = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
            minElem = array[i];
            numberRowsMatrix = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {numberRowsMatrix} строка");
}


int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] arraySumRowsMatrix = ArraySumRowsMatrix(array2d);
NumberRowsMinSumMatrix(arraySumRowsMatrix);