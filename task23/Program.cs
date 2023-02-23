// Задача 23. Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Prompt("Введите натуральное число: ");
if (number>0) PrintCube(number);
else Console.WriteLine("Введено не натуральное число. Начните заново");

void PrintCube(int n)
{
    Console.WriteLine(" Число   Куб числа");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i, 5}    {Math.Pow(i, 3), 7}");
    }
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}