// Задача 69. Напишите программу, которая
// на вход принимает два числа А и В, и 
// возводит число А в целую степень В с помощбю рекурсии.
// A=3; B=5 -> 243
// A=2; B=3 -> 8


Console.WriteLine("Введите число, возводимое в степень: ");
int numbe = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число степени: ");
int power = int.Parse(Console.ReadLine());

if (power < 0) Console.WriteLine("Ошибка ввода степени. Степень не может быть отрицательной");
else
{
    int powNumber = PowNumber(numbe, power);
    Console.WriteLine($"{powNumber}");
}

int PowNumber(int num, int pow)
{
    if (pow == 0) return 1;
    else return num * PowNumber(num, pow - 1);
}


//    или оптимизированный метод

// int PowNumber(int num, int pow)
// {
//     if (pow == 0) return 1;
//     else if (pow % 2 == 0) return PowNumber(num * num, pow / 2);
//     else return PowNumber(num, pow - 1) * num;
// }