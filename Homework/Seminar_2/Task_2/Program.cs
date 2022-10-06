// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);            
int Compound(int number)                    
{
    int a = number % 10;                                     
    int b = number / 100 % 10;                   
    int result = b * 10 + a;               
    return result;                                   
}
System.Console.WriteLine($"{number} -> {Compound(number)}");
