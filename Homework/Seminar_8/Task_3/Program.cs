// Задача 3: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixResult;
}

int[,] array1 = CreateArray(3, 3);
PrintArray(array1);
System.Console.WriteLine();
int[,] array2 = CreateArray(3, 3);
PrintArray(array2);

if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Умножение матриц невозможно.");
    Console.WriteLine("Число столбцов матрицы 1 должно совпадать с числом строк матрицы 2.");
}
else
{
    int[,] result = MatrixProduct(array1, array2);
    System.Console.WriteLine();
    PrintArray(result);
}