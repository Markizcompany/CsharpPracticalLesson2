// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


Console.WriteLine("Введите число M: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("");


if (firstNumber < secondNumber)
{
    SumElemOneToSecondNum(firstNumber, secondNumber, 0);
}
else
{
    SumElemOneToSecondNum(secondNumber, firstNumber, 0);
}
Console.WriteLine("");


void SumElemOneToSecondNum(int num1, int num2, int sum)
{
    if (num1 > num2)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
        return;
    }
    sum += num1++;
    SumElemOneToSecondNum(num1, num2, sum);
}
