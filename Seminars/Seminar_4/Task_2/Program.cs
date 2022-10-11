// Задача 2: 
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Count(int number)
{
    int result = 0;
    while (number > 0)
    {
        number = number / 10;
        result++;
    }
    return result;
}

int number = InputNumber("Введите число: ");
int result = Count(number);
System.Console.WriteLine($"{result}");
