// Задача 7:
// Вывести следующий ряд последовательности
// 1, 2, 2, 3, 3, 3,..., 10

int Prompt()
{
    System.Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt();

for (int i = 1; i <= number; i++)
{
    for (int j = 0; j < i; j++)
    {
        System.Console.Write($"{i}, ");
    }
}