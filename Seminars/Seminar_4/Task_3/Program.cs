// Задача 3: 
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = InputNumber("Введите число: ");
int multiplay = 1;
for (int i = 1; i <= N; i++)
{
    multiplay = multiplay *i;
}

System.Console.WriteLine($"{N} -> {multiplay}");
