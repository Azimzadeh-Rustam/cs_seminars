// 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

int[,] CreateMatrixSumIndexes(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j], 5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixSumIndexes(3, 4);
PrintArray(matrix);