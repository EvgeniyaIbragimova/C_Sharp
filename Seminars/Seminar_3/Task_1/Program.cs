// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string msg)
{
System.Console.Write(msg);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

bool ValdateCoords(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord == 0)
    {
        System.Console.WriteLine("Точка назодится как минимум на одной из осей");
        return false;
    }

    return true;
}

int x = Prompt("Введите X > ");
int y = Prompt("Введите Y > ");

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1 четверть");
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("4 четверть");
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("2 четверть");
}
if (x < 0 && y < 00)
{
    System.Console.WriteLine("3 четверть");
}