// Задача 3: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

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

void PrintMatrix(int[,] array)
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] Dictionary(int[,] matrix)
{
    int[] dict = new int[10];
    for (int i = 0; i < dict.Length; i++)
    {
        int count = 0;
        foreach (var item in matrix)
        {
            if (item == i)
            {
                count++;
            }
            dict[i] = count;
        }
    }
    return dict;
}

int[,] matrix = CreateArray(3, 3);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] dict = Dictionary(matrix);
PrintArray(dict);
