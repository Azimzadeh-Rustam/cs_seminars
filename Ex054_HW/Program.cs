// 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortRowDescending(int[] row)
{
    int size = row.Length;
    for(int i =  1; i < size; i++)
    {
        int key = row[i];
        int j = i - 1;

        while (j >= 0 && row[j] < key)
        {
            row[j + 1] = row[j];
            j = j - 1;
        }
        row[j + 1] = key;
    }
}

void SortEachRowDescending(int[,] mtr)
{
    int rows = mtr.GetLength(0);
    int columns = mtr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int[] row = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            row[j] = mtr[i, j];
        }
        
        SortRowDescending(row);

        for (int j = 0; j < columns; j++)
        {
            mtr[i, j] = row[j];
        }
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
SortEachRowDescending(matrix);
Console.WriteLine();
PrintMatrix(matrix);