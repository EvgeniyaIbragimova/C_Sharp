﻿// Задайте значения M и N.
// Напишите программу, которая рекурсивно
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ShowNaturalRow(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
    ShowNaturalRow(numberM,  numberN - 1);
    Console.WriteLine(numberN);
}

int numberM = Prompt("Введите число M -> ");
int numberN = Prompt("Введите число N -> ");
ShowNaturalRow(numberM, numberN);