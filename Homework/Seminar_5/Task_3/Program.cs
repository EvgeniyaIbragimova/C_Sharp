// Задача 3: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] CreateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}\t");
    }
    System.Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] myArray = CreateArray(5);
PrintArray(myArray);
double dif = FindMax(myArray) - FindMin(myArray);

System.Console.WriteLine($"{FindMax(myArray):f2} - {FindMin(myArray):f2} = {dif:f2}");
