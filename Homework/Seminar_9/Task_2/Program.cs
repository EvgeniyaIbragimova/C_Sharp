// Задача 2: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNaturalElements(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return 0;
    }
    return SumNaturalElements(numberM + 1, numberN) + numberM;
}

int numberM = Prompt("Введите число M -> ");
int numberN = Prompt("Введите число N -> ");
if (numberM > numberN)
{
    Console.WriteLine($"Число M не должно быть больше числа N");
}
else
{
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {SumNaturalElements(numberM, numberN)}");
}