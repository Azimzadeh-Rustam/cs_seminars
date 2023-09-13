// 62. Заполните спирально массив 4 на 4.

void FillSpiralMatrix(int[,] mtr)
{
    int size = mtr.GetLength(0);
    int value = 1;
    int startRow = 0, endRow = size - 1, startCol = 0, endCol = size - 1;

    while (value <= size * size)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            mtr[startRow, i] = value;
            value++;
        }
        startRow++;

        for (int i = startRow; i <= endRow; i++)
        {
            mtr[i, endCol] = value;
            value++;
        }
        endCol--;

        for (int i = endCol; i >= startCol; i--)
        {
            mtr[endRow, i] = value;
            value++;
        }
        endRow--;

        for (int i = endRow; i >= startRow; i--)
        {
            mtr[i, startCol] = value;
            value++;
        }
        startCol++;
    }
}

void PrintMatrix(int[,] matrix)
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

int size = 4;
int[,] matrix = new int[size, size];
FillSpiralMatrix(matrix);
PrintMatrix(matrix);