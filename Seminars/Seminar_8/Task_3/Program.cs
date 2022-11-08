// Задача 3: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

// Задача 1: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[] FrequeDict(int[,] matrix)
{
    int[] dict = new int [10];
    foreach (var item in matrix)
    {
        dict[item]++;
    } 
    return dict;
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
System.Console.WriteLine();
int[] dict = FrequeDict(array);

