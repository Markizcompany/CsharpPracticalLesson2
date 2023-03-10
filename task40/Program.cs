// Задача 40. Напишите программу, которая
// принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.


bool TriangleInequalityTheorem(int firstNum, int secondNum, int thirdNum)
{
 return firstNum < secondNum + thirdNum && secondNum < firstNum + thirdNum && thirdNum < firstNum + secondNum;
}


Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

bool triangleInequalityTheorem = TriangleInequalityTheorem(firstNumber, secondNumber, thirdNumber);
Console.WriteLine(triangleInequalityTheorem ? "Да" : "Нет");