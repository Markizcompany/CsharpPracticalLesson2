// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double degree = Degree(numberA, numberB);

if (numberA > 0 && numberB > 0) Console.WriteLine(degree);
else Console.WriteLine("Введено не натуральное число. Начните заново");

double Degree(int numA, int numB)
{
    return Math.Pow(numA, numB);
}