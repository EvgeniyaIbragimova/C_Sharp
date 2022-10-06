// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);            
int Compound(int number)                    
{
    int c = number % 10;                                     
    int a = number / 100 % 10;                   
    int result = a * 10 + c;               
    return result;                                   
}
System.Console.WriteLine($"{number} -> {Compound(number)}");
