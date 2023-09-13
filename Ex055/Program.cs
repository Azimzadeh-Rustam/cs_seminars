// 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

bool IsSquareMatrix(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    return rows == columns;
}

void ReplaceRowsToColumns(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < i; j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
if(!IsSquareMatrix(matrix))
{
    Console.WriteLine("Невозможно транспанировать матрицу, поскольку матрица не квадратная");
    return;   
}
PrintArray(matrix);
ReplaceRowsToColumns(matrix);
Console.WriteLine();
PrintArray(matrix);