// Задача 1: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindNaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
    if (numberM % 2 == 0)
    {
        Console.Write($"{numberM}\t");
    }
    FindNaturalNumbers(numberM + 1, numberN);
}

int numberM = Prompt("Введите число M -> ");
int numberN = Prompt("Введите число N -> ");
if (numberM > numberN)
{
    Console.WriteLine($"Число M не должно быть больше числа N");
}
else
{
    FindNaturalNumbers(numberM, numberN);
}
Console.WriteLine();