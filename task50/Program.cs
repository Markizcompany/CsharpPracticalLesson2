// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];  // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  // или rows
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
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}


void SearchingMatrixElems(int[,] matrix, int rows, int colums)
{
    if (rows < 0 || colums < 0) Console.WriteLine("Ошибка. Позиция элемента массива не может быть отрицательной, начните заново");
    else
    {
        if (rows > matrix.GetLength(0) || colums > matrix.GetLength(1))
            Console.WriteLine("Такого элемента в массиве нет");
        else Console.WriteLine($"Элемент массива по заданными позициями: {matrix[rows, colums]}");
    }
}


int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);

Console.Write("Введите строку элемента массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
SearchingMatrixElems(array2d, rows, colums);
Console.WriteLine();