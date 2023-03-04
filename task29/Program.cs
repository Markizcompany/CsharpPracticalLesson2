// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение чисел: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = ArrayGeneration(length, min, max);
Console.WriteLine("Массив:");
PrintArray(array);

int[] ArrayGeneration(int lenght, int minValue, int maxValue)
{
    Random random = new Random();
    int[] arr = new int[lenght];
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}