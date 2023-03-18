// Задача 48.
// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m=3, n=4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] CreateMatrixRndInt(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];  // 0, 1
    for (int i = 0; i < matrix.GetLength(0); i++)  // или rows  вместо matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // colums
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)    //(int i = 0; i < size; i++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4);
PrintMatrix(array2d);