// 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] copyArr = new int[array.Length];
    for (int i =0; i < copyArr.Length; i++) {
        copyArr[i] = array[i];
    }
    return copyArr;
}

int[] CreateArrayRndInt(int size, int min, int max) // size = 6
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
Console.WriteLine();
int[] array1 = CopyArray(array);
array1[0] = 100;
PrintArray(array1);
Console.WriteLine();
PrintArray(array);