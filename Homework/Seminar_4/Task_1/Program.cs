// Задача 1: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). 
// Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = Prompt("Введите число А: ");
int numberB = Prompt("Введите число В: ");

int Degree(int result1, int result2)
{
    int result = 1;
    for (int i = 0; i < result2; i++)
    {
        result = result * result1;
    }
    return result;
}

if (numberB < 0)
{
    System.Console.WriteLine($"Некорректный ввод");
}
else Console.WriteLine($"{numberA}, {numberB} -> {Degree(numberA, numberB)}");