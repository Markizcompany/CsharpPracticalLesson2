// Задача 19. Напишите программу, которая
// принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int number = Prompt("Введите число ");
int reverseNumber = ReverseNumber(number);
if (number == reverseNumber) Console.WriteLine("да");
else Console.WriteLine("нет");


int ReverseNumber(int num)
{
    int revNum = 0;
    int lastNum;
    while (num > 0)
    {
        lastNum = num % 10;
        revNum = revNum * 10 + lastNum;
        num = num / 10;
    }
    return revNum;
}



int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}