// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (ValidateNumber(number))
{
    Console.WriteLine($"{GetThirdRank(number)}");
}
else
Console.WriteLine("Третьей цифры нет");


bool ValidateNumber(int num)
{
    return num >= 100;
}


int GetThirdRank(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}