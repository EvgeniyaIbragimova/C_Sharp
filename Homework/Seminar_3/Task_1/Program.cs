// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool CorrectNumber(int number)
{
    if (number > 9999 & number < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int ReversalNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        int remainder = number % 10;
        number = number / 10;
        result = result * 10 + remainder;
    }
    return result;
}

bool CheckEquality(int result1, int result2)
{
    if (result1 == result2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int number = Prompt("Введите пятизначное число: ");
bool correct = CorrectNumber(number);
if (correct)
{
    {
        int reversal = ReversalNumber(number);
        bool Palindrome = CheckEquality(number, reversal);
        if (Palindrome)
        {
            Console.WriteLine($"{number} -> Это палиндром");
        }
        else
        {
            Console.WriteLine($"{number} -> Это не палиндром");
        }
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
