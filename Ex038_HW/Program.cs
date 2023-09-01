// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double Round(double number)
{
    return Math.Round(number, 1, MidpointRounding.ToZero);
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    double arrElem;

    for(int i = 0; i < arr.Length; i++)
    {
        arrElem = rnd.NextDouble() * (max - min) + min;
        arr[i] = Round(arrElem);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(4, -50, 50);
double maxElem = FindMax(array);
double minElem = FindMin(array);
double difference = maxElem - minElem;
PrintArray(array);
Console.Write($" -> {Round(difference)}");