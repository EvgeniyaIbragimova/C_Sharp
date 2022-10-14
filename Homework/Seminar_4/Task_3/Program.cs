// Задача 3: 
// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8


int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int start = Prompt("Введите начало диапазона массива: ");
int end = Prompt("Введите конец диапазона массива: ");
int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(start, end);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);
