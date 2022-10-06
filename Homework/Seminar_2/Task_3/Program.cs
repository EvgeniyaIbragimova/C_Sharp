// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Compound(int number)
{
    int a = number % 10;
    int result = a;
    return result;
}
if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    System.Console.WriteLine(Compound(number));
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
