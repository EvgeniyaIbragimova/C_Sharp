﻿// Задача 2: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12



















// int Prompt(string message)
// {
//     Console.Write(message);
//     string readValue = Console.ReadLine();
//     int result = int.Parse(readValue);
//     return result;
// }
 
// int SumOfDigitsOfNumber(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }

// int value = Prompt("Введите значение числа -> ");
// if (value >= 0)
//     {
//     System.Console.WriteLine($"{value} -> {SumOfDigitsOfNumber(value)}");
//     }
// else System.Console.WriteLine("Некорректный ввод, введите положительное число");  