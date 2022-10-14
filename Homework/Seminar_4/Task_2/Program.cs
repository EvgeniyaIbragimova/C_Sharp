// Задача 2: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите число: ");

int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

if (number >= 0)
{
    System.Console.WriteLine($"{number} -> {Sum(number)}");
}
else System.Console.WriteLine("Введите положительное число");
