// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


int[,] RegularizeMatrix(int[,] matrix)
{
    int sizeRowsArray = matrix.GetLength(0);
    int sizeColumsArray = matrix.GetLength(1);
    for (int rows = 0; rows < sizeRowsArray; rows++)
    {
        for (int colums = 0; colums < sizeColumsArray; colums++)
        {
            for (int i = 0; i < sizeRowsArray; i++)    // сортируем каждую строку массива, как в одномерном массиве
            {
                for (int j = 0; j < sizeColumsArray - 1; j++)
                {
                    int temp;
                    if (matrix[i, j] < matrix[i, j + 1])
                    {
                        temp = matrix[i, j];
                        matrix[i, j] = matrix[i, j + 1];
                        matrix[i, j + 1] = temp;
                    }
                }
            }
        }
    }
    return matrix;
}


int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[,] regularizeMatrix = RegularizeMatrix(array2d);
PrintMatrix(regularizeMatrix);