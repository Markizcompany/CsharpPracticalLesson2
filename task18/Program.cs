// Задача 18. Напишите программу, которая 
// по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
//    Y
//  2 | 1
// ---|---X
//  3 | 4


// методы
string Prompt(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

string Range(string num)
{
    if (num == "1") return "x > 0,  y > 0";
    if (num == "2") return "x < 0,  y > 0";
    if (num == "3") return "x < 0,  y < 0";
    if (num == "4") return "x > 0,  y < 0";
    return "0";
}


// тело программы
string number = Prompt("Введите номер четверти ");
string range = Range(number);
string result = range=="0" ?
                "Некорректный ввод данных"
                : $"диапазон возможных координат точек в этой четверти {range}";
Console.WriteLine(result);