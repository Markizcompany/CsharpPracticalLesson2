// Задача 46. 
// Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.
// m = 3, n = 4.

// 1    4    8   19
// 5   -2   33   -2
// 77   3    8    1


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];  // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  // или rows  вместо matrix.GetLength(0)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)    //(int i = 0; i < size; i++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("|");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);