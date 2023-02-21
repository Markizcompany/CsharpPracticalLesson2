// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, обозначающее день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <=7)
{
    if (DayWeek(number)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Вы ввели число, не обозначающее день недели");

bool DayWeek(int num)
{
    return num == 6 || num == 7;
}