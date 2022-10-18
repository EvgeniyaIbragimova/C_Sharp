// Задача 3: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Binarny(int number)
{
    int[] array = new int[10];
    int count = array.Length - 1;
    while (number > 0)
    {
    array[count] = number % 2;
    number /= 2;
    count--;
    }
return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine();
}

int number = Prompt("Введите число: ");
PrintArray(Binarny(number));
