// Задача 55.
// Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна
// вывести сообщение для пользователя.


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
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}


void ReplaceRowsToColums(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}


int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();

int rows = array2d.GetLength(0);
int colums = array2d.GetLength(1);
if (rows != colums) Console.WriteLine("Невозможно в данном массиве поменять строки на столбцы");
else
{
    ReplaceRowsToColums(array2d);
    PrintMatrix(array2d);
}
