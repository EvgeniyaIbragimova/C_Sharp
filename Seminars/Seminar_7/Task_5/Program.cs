// Задача 5: 
// Задайте двумерный массив. 
// Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, 
// или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]

// Введенный элемент 6, результат: такого элемента нет.

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateArray(int lenRow, int lenColumns)
{
    int[,] array = new int[lenRow, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-5, 6);
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

(int, int) Search(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return (i, j);
            }
        }
    }
    return (-1, -1);
}

int[,] array = CreateArray(4, 5);
PrintArray(array);
int number = Prompt("Введите искомое число: ");
(int line, int column) = Search(array, number);
if (line == -1)
{
    System.Console.WriteLine("Нет искомого числа");
}
else
{
    System.Console.WriteLine($"Координаты [{line}, {column}]");
}
