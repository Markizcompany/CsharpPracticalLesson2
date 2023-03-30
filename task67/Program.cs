// Задача 67. Напишите программу, которая будет
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);

int SumDigits(int num)
{
    if (num == 0) return num;
    else return num % 10 + SumDigits(num / 10);
}