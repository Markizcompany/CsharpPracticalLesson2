// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number < 1000)
{
    int newnumber = SecNumber(number);
    Console.WriteLine($"{newnumber}");
}
else Console.WriteLine("Вы ввели не трехзначное число");

int SecNumber (int num)
{
    int firstNum = num % 100;
    int secondNum = firstNum / 10;
    return secondNum;
}