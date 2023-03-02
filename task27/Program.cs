// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine($"Сумма цифр в числе = {sum}");

int Sum(int num)
{
    int res = 0;
    int numB = 0;
    while (num != 0)
    {
        numB = num % 10;
        res = res + numB;
        num = num / 10;
    }
    return res;
}