// Задача 5: 
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] RandomArrGen()
{
    int length = new Random().Next(1, 15);
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;

}

int[] Copy(int[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

int[] array = RandomArrGen();
int[] array2 = array;
int[] array3 = Copy(array);
PrintArray(array);
array[0] = -1;
PrintArray(array);
PrintArray(array2);
PrintArray(array3);