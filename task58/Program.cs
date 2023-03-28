// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int[,] ProductMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] productMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int x = 0; x < secondMatrix.GetLength(0); x++)
            {
                productMatrix[i, j] += firstMatrix[i, x] * secondMatrix[x, j];
            }
        }
    }
    return productMatrix;
}


int[,] firstMatrix = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(secondMatrix);
Console.WriteLine();

int[,] productMatrix = ProductMatrix(firstMatrix, secondMatrix);
PrintMatrix(productMatrix);