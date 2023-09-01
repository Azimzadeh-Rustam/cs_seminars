// 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
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

int CountTheNumberOfEvenElements(int[] mass)
{
    int count = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(4);
int evenElements = CountTheNumberOfEvenElements(array);
Console.Write($"В массиве ");
PrintArray(array);
Console.Write($" количество чётных элементов равно {evenElements}");