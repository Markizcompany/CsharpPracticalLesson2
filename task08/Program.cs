// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
double number = Convert.ToDouble(Console.ReadLine());
if (number > 0)
    if (number % 1 == 0)
    {
        int count = 2;
        while (count <= number)
        {
            Console.Write($"{count} ");
            count = count + 2;
        }
    }
    else Console.WriteLine("Введено неверное число. Введите натуральное число");
else Console.WriteLine("Введено неверное число. Введите натуральное число");