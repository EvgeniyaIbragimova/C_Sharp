// Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А
// в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PowerAB(int numberA, int numberB)
{
    if (numberB == 0)
    {
        return 1;
    }
    return numberA * PowerAB (numberA, numberB - 1);
}

int numberA = Prompt("Введите число A -> ");
int numberB = Prompt("Введите число B -> ");
int answer = PowerAB(numberA, numberB);
System.Console.WriteLine($"{numberA}; {numberB} -> {answer}");