// Задача 41. 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateArray(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}


int CounterPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


Console.Write("Какое количество цифр будет введено: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа: ");
int[] array = CreateArray(lenghtArray);
Console.WriteLine();
int counterPositiveNumber = CounterPositiveNumber(array);
Console.WriteLine($"Количество чисел больше 0 =  {counterPositiveNumber}");



//       ЭТАЛОННОЕ РЕШЕНИЕ

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }


// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
// }


// int[] InputArray(int lenght)
// {
//     int[] array = new int[lenght];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Prompt($"Введите {i + 1}-й элемент ");
//     }
//     return array;
// }


// int CounterPositiveNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// int lenght = Prompt("Введите количество элементов > ");
// int[] array;
// array = InputArray(lenght);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CounterPositiveNumber(array)}");