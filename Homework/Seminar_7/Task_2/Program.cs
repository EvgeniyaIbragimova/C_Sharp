// Задача 2:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int[,] CreateArray(int lenRow, int lenColumns)
{
    int[,] array = new int[lenRow, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 9);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindPosition(int[,] matrix, int value1, int value2)
{
    int j = value1;
    int i = value2;
    if (i >= matrix.GetLength(0) || i < 0 || j >= matrix.GetLength(1) || j < 0)
    {
        Console.WriteLine($"{value1} , {value2} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"{value1}, {value2} -> {matrix[i, j]}");
    }
}

int[,] array = CreateArray(3, 3);
PrintArray(array);
int number1 = Prompt("Введите номер строки: ");
int number2 = Prompt("Введите номер столбца: ");
FindPosition(array, number1, number2);
