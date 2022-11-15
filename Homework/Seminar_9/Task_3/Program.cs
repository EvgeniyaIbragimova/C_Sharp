// Задача 3: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else
    {
        if (numberN == 0 && numberM > 0)
        {
            return AckermanFunction(numberM - 1, 1);
        }
        else
        {
            return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
        }
    }
}

int numberM = Prompt("Введите число m -> ");
int numberN = Prompt("Введите число n -> ");
Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {AckermanFunction(numberM, numberN)}");