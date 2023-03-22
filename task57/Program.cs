// Задача 57. Составить частотный словарь элементов
// двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

//     Набор данный                Частотный словарь
// {1, 9, 9, 0, 2, 8, 0, 9}       0 встречается 2 раза
//                                1 встречается 1 раз
//                                2 встречается 1 раз
//                                8 встречается 1 раз
//                                9 встречается 3 раза

// 1, 2, 3                        1 встречается 3 раза
// 4, 6, 1                        2 встречается 2 раза
// 2, 1, 6                        3 встречается 1 раз
//                                4 встречается 1 раз
//                                6 встречается 2 раза


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


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


int[] MatrixToArray(int[,] matrix)
{
    int elem = 0;
    int[] array = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[elem] = matrix[i, j];
            elem += 1;
        }
    }
    return array;
}


void SumElemArray(int[] array)
{
    int count = 1;
    int curentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == curentNumber) count++;
        else
        {
            Console.WriteLine($"Число {curentNumber} встречается {count} раз");
            curentNumber = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {curentNumber} встречается {count} раз");
}


int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
int[] array = MatrixToArray(array2d);
PrintArray(array);
Console.WriteLine();
Array.Sort(array);       //Сортировка чисел массива
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
SumElemArray(array);