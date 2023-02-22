// 17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
//    Y
//  2 | 1
// ---|---X
//  3 | 4

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc);    // условие ? значение(если выполняется условие) : другое значение (если условие не выполняется)
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти {quarter}"
                : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}