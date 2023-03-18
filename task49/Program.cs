// Задача 49.
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и
// замените эти элементы на их квадраты.

// Например.       
// Изначально массив        Новый массив
// выглядел вот так:        будет выглядеть вот так:
// 1  4  7  2               1  4  49  2
// 5  9  2  3               5  9   2  3
// 8  4  2  4              64  4   4  4


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
        for (int j = 0; j < matrix.GetLength(1); j++)    //(int i = 0; i < size; i++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}


void ReplaceEvenElems(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }
    }
}



int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceEvenElems(array2d);
PrintMatrix(array2d);