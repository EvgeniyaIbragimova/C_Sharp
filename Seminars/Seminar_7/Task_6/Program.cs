// Задача 6:
// Найти минимальное число

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

int Min(int[,] array)
{
    int min = array[0, 0];
    foreach (int item in array)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
int min = Min(array);
System.Console.WriteLine($"Минимальныэ элемент -> {min}");