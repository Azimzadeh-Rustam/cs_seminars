// 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] arr, int nmb)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == nmb) return true;
    }
    return false;
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

int[] array = CreateArrayRndInt(5, -6, 6);
int number = 5;
bool answer = FindNumber(array, number);
Console.Write($"Присутсиве числа {number} в массиве ");
PrintArray(array);
Console.Write(answer ? " Да" : " Нет");