// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000)
{
    int result1 = number / 10;
    int result2 = result1 % 10;
    System.Console.WriteLine($"{number} -> {result2}");
} 
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}