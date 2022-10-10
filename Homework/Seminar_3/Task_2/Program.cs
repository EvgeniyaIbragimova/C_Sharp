// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int x1 = Prompt("Введите координаты точки А: X1 -> ");
int y1 = Prompt("Введите координаты точки А: Y1 -> ");
int z1 = Prompt("Введите координаты точки А: Z1 -> ");
int x2 = Prompt("Введите координаты точки B: X2 -> ");
int y2 = Prompt("Введите координаты точки А: Y2 -> ");
int z2 = Prompt("Введите координаты точки А: Z2 -> ");

int Power(int arg)
{
    return arg * arg;
}

double length = Math.Sqrt(Power(x1 - x2) + Power(y1 - y2) + Power(z1 - z2));

System.Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {length:f2}");
