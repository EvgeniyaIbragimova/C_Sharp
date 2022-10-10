// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// const int X = 0;
// const int Y = 0;
// const int Z = 0;

// int Prompt(string msg)
// {
//     System.Console.Write(msg);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int[] InputPoint(int point)
// {
//     int[] answer = new int[2];
//     answer[X] = Prompt($"Введите x {point} -> ");
//     answer[Y] = Prompt($"Введите y {point} -> ");
//     answer[Z] = Prompt($"Введите z {point} -> ");
//     return answer;
// }

// int Power2(int arg)
// {
//     return arg * arg;
// }

// int[] p1 = InputPoint(1);
// int[] p2 = InputPoint(2);
// int[] p3 = InputPoint(3);

// double lenght = Math.Sqrt(Power2(p1[X] - p2[X]) + Power2(p1[Y] - p2[Y]) + Power2(p1[Z] - p2[Z]));

// System.Console.WriteLine($"{lenght:f2}"); // f2 -> количество знаков после запятой







int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int x1 = Prompt("Введите значение координаты точки А по оси X -> ");
int y1 = Prompt("                                    по оси Y -> ");
int z1 = Prompt("                                    по оси Z -> ");
int x2 = Prompt("Введите значение координаты точки B по оси X -> ");
int y2 = Prompt("                                    по оси Y -> ");
int z2 = Prompt("                                    по оси Z -> ");

double VectorLength()
{
    double length = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return length;
}

double length = VectorLength();
Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {length}");
Console.WriteLine();










