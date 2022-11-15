// Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumDigital(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return SumDigital(number / 10) + number % 10;
    }

int number = Prompt("Введите число -> ");
int result = SumDigital(number);
System.Console.WriteLine($"{number} -> {result}");
