// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да a = 2 b = 10 -> нет a = 9; b = -3 -> нет a = -3 b = 9 -> да

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine($"{a} является квадратом {b}");
}
else if (b == a*a)
{
    Console.WriteLine($"{b} является квадратом {a}");
}
else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}