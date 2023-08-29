// 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] PairArrayElemMultiplication(int[] arr)
{
    int size = arr.Length;
    int newSize = size / 2 + size % 2;
    int[] newArr = new int[newSize];
    for(int i = 0; i < newSize; i ++)
    {
        newArr[i] = arr[i] * arr[size - 1 - i];
    }
    if(size % 2 == 1) newArr[newSize - 1] = arr[size / 2];
    return newArr;
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
int[] pairArr = PairArrayElemMultiplication(array);
Console.Write(" -> ");
PrintArray(pairArr);