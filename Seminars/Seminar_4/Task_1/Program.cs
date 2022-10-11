// Задача 1:
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Ввод числа по приглашению
int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// Сумма чисел от 1 до number
int SumNumbers(int number)
{
    int sum = 0; // накапливаем сумму
    for (int i = 1; i <= number; i++) // цикл от 1 до number
    {
        sum += i;    // sum = sum + i суммируем
    }
    return sum;  // возврат суммы из метода
}

// Проверка на правильность ввода
bool ValidateNumber(int number)
{
    if (number <1) // при числе меньше 1 не работаем
    {
        System.Console.WriteLine("Число меньше единицы, сумма не считается");
        return false;
    }
    return true;
}

int n = InputNumber("Введите число -> ");
if (ValidateNumber(n))
{
    System.Console.WriteLine($"Сумма чисел от 1 до {n} -> {SumNumbers(n)}");
}
