// 56. Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] mtr = new int[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            mtr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return mtr;
}

void PrintMatrix(int[,] mtr)
{
    int rows = mtr.GetLength(0);
    int columns = mtr.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write($"{mtr[i, j], 5}");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] SumOfElementsInEachRow(int[,] mtr)
{
    int rows = mtr.GetLength(0);
    int columns = mtr.GetLength(1);
    int[] sums = new int[rows];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            sums[i] += mtr[i, j];
        } 
    }
    return sums;
}

int FindMinNumberIndexInArray(int[] arr)
{
    int minNumber = arr[0];
    int minNumberIndex = 0;
    int size = arr.Length;
    for(int i = 1; i < size; i++)
    {
        if(arr[i] < minNumber)
        {
            minNumber = arr[i];
            minNumberIndex = i;
        }
    }
    return minNumberIndex;
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
int[] sumOfElementsInEachRow = SumOfElementsInEachRow(matrix);
int rowWithMinimumSum = FindMinNumberIndexInArray(sumOfElementsInEachRow);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальная сумма у данной матрицы в {rowWithMinimumSum + 1}-ой строке. Она равна -> {sumOfElementsInEachRow[rowWithMinimumSum]}.");
Console.Write($"В каждой строке следующие суммы -> ");
PrintArray(sumOfElementsInEachRow);