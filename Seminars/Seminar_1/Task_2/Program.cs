// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Понедельник");
}
if (a == 2)
{
    Console.WriteLine("Вторник");
}
if (a == 3)
{
    Console.WriteLine("Среда");
}
if (a == 4)
{
    Console.WriteLine("Четверг");
}if (a == 5)
{
    Console.WriteLine("Пятница");
}
if (a == 6)
{
    Console.WriteLine("Суббота");
}
if (a == 7)
{
    Console.WriteLine("Воскресенье");
}

Console.WriteLine("Введите число ");
int day = Convert.ToInt32(Console.ReadLine());
string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (day < 1 || day > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
{
    Console.WriteLine(days[day - 1]);
}

switch(day)
{
    case 1: Console.WriteLine("Понедельник");
    break;
    case 2: Console.WriteLine("Вторник");
    break;
    case 3: Console.WriteLine("Среда");
    break;
    case 4: Console.WriteLine("Четверг");
    break;
    case 5: Console.WriteLine("Пятница");
    break;
    case 6: Console.WriteLine("Суббота");
    break;
    case 7: Console.WriteLine("Воскресенье");
    break;
}