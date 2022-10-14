// Задача 5:
// Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

// дорешать самостоятельно дополнительно!

int[] array = {1, 2, 3, 4};
int max = array[0];
int secondMax = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        secondMax = max;
        max = array[i];
    }
    else if (secondMax < array[i] && array [i] != max)
    {
        secondMax = array[i];
    }
}

System.Console.WriteLine(secondMax);
System.Console.WriteLine(max);


// int SearchSecondMax(int[] array)
// {
//     int max = array[0];
//     int secondMax = array[0];
 
//     for (int i = 2; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             secondMax = max;
//             max = array[i];
//         }
//         if (secondMax == max)
//         {
//             if (i < array.Length-1)
//             {
//                 secondMax = array[i+1];
//             }
//         }
//         if (array[i] > secondMax & array[i] != max)
//         {
//             secondMax = array[i];
//         }
//     }
//     return secondMax;
// }







