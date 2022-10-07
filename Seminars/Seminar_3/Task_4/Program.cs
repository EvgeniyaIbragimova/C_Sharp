// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt("Введите число: ");
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(Math.Pow(i, 2));
}