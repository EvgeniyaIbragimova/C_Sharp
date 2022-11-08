// Задача 4: 
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

(int, int) FindMin(int[,] matrix)
{
    int indRow = 0;
    int indCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[indRow, indCol])
            {
                indRow = i;
                indCol = j;
            }
        }
    }
    return (indRow, indCol);
}

int[,] ChangeMatrix(int[,] matrix)
{
    int[,] ans = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    (int minRow, int minCol) = FindMin(matrix);
    int a = 0;
    int b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != minRow)
        {
            b = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == minRow || j == minCol)
                {

                }
                else
                {
                    ans[a, b] = matrix[i, j];
                    b++;
                }
            }
            a++;
        }
    }
    return matrix;
}