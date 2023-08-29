// 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int RangeElementCount(int[] arr, int min, int max)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= min && arr[i] <= max) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите максимальное число для диапазона поиска: ");
int maxNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число для диапазона поиска: ");
int minNum = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(123, -100, 100);
PrintArray(array);
int answer = RangeElementCount(array, minNum, maxNum);
Console.WriteLine();
Console.WriteLine(answer);