// Задача 30. Напишите программу, которая
// выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите длину массива: ");
int lngth = Convert.ToInt32(Console.ReadLine());

int[] arr = ArrayGeneration(lngth, 0, 1);

Console.WriteLine("Генерируемый массив: ");
PrintArray(arr);


int[] ArrayGeneration(int lngth, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[lngth];
    for (int i = 0; i < lngth; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write($", ");
    }
}

