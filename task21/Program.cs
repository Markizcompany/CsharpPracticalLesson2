// Задача 21. Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ax = Prompt("Введите координаты x точки A: ");
int ay = Prompt("Введите координаты y точки A: ");
int az = Prompt("Введите координаты z точки A: ");
Console.WriteLine("");
int bx = Prompt("Введите координаты x точки B: ");
int by = Prompt("Введите координаты y точки B: ");
int bz = Prompt("Введите координаты z точки B: ");

double result = Distance(ax, ay, az, bx, by, bz);
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double sunCube = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
    double res = Math.Sqrt(sunCube);
    return res;
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}