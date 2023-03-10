// Задача 42. Напишите программу, которая
// будет переобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


//       Способ №1  Через строку  (через строку дольше работает)

// string TrasformationNumber(int num)
// {
//     string newNum = string.Empty;
//     while (num != 0)
//     {
//         newNum = num % 2 + newNum;
//         num = num / 2;
//     }
//     return newNum;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string trasformationNumber = TrasformationNumber(number);
// Console.WriteLine(trasformationNumber);


//   Способ №2   Через число



int DecToBin(int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result = result + num % 2 * count;
        num = num / 2;
        count *= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int decToBin = DecToBin(number);
Console.WriteLine(decToBin);