// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.

int[] arr = CreateArray(8);
PrintArray(arr);  // PrintArray(CreateArray(8));

int[] CreateArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 2);
    }
    return res;
}

void PrintArray(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     // Console.Write(arr[i]);
    // }
    Console.Write ($"[{string.Join (", ", arr)}]");
}

