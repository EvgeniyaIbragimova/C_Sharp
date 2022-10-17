// Задача 2: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] myArray = CreateArray(5, 1, 10);
PrintArray(myArray);

int SumPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях -> {SumPosition(myArray)}");
