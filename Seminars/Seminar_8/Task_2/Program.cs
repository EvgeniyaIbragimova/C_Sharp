// Задача 2:
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

bool ValidateMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    return false;
}

int[,] TranspasitionMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = j; i < matrix.GetLength(0); i++)
        {
            int number = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = number;
        }
    }
    return matrix;
}

int[,] array = CreateArray(3, 3);
PrintArray(array);
System.Console.WriteLine();

if (ValidateMatrix(array))
{
    TranspasitionMatrix(array);
    PrintArray(array);
}
else
{
    System.Console.WriteLine("Матрица не квадратная!");
}
