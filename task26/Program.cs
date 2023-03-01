// Задача 26. Напишите программу, которая
// принимает на вход число и
// выдаёт количество цифр в числе.
// 465 -> 3
// 78 -> 2
// 89126 -> 5


int number = Prompt("Введите число: ");
int digit = CheckDigit(number);
Console.WriteLine($"{number} -> {digit}");


int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int CheckDigit(int num)
{
    int result = 0;
    if (num == 0) return 1;
    else
    {
        while (num != 0)
        {
            num = num / 10;
            result = result + 1;
        }
    }
    return result;
}