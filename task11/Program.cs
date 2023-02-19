// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число -> {number}");

int sum = TwoDigitNumber(number);
Console.WriteLine($"{sum}");

int TwoDigitNumber(int num)
{
    int firstNum = num / 100;
    int secondNum = num % 10;
    return firstNum * 10 + secondNum;
}