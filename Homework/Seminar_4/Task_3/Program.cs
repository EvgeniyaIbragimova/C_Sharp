// Задача 3: 
// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8


int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 20);
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

int[] array = new int[8];
FillArray(array);
PrintArray(array);




















// int Prompt(string message)
// {
//     Console.Write(message);
//     string readValue = Console.ReadLine();
//     int result = int.Parse(readValue);
//     return result;
// }

// // Функция генерации массива
// int[] FillArray(int Length, int lowLimit, int hiLimit)
// {
//     int[] array = new int[Length];
//     int i = 0;
//     while (i < array.Length)
//     {
//         array[i] = new Random().Next(lowLimit, hiLimit);
//         i++;
//     }
//     return array;
// }

// // Функция вывода массива
// void PrintArray(int[] array)
// {
//     int count = 0;
//     while (count < array.Length)
//     {
//         Console.Write($"{array[count]} \t");
//         count++;
//     }
// }
// int count = Prompt("Введите число N, соответствующее количеству элементов в массиве -> ");
// int lowLimit = Prompt("Введите число, соответствующее нижней границе диапазона -> ");
// int hiLimit = Prompt("                              верхней границе диапазона -> ");
// int[] set = FillArray(count, lowLimit, hiLimit);
// PrintArray(set);
// System.Console.WriteLine();