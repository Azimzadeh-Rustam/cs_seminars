// 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

bool ValidationOfThePossibilityOfMatrixMultiplication(int[,] mtrA, int[,] mtrB)
{
    int columns = mtrA.GetLength(1);
    int rows = mtrB.GetLength(0);
    return columns == rows;
}

int[,] MatricesMultiplication(int[,] mtrA, int[,] mtrB)
{
    int rowsA = mtrA.GetLength(0);
    int columnsA = mtrA.GetLength(1);

    int rowsB = mtrB.GetLength(0);
    int columnsB = mtrB.GetLength(1);

    int[,] result = new int[rowsA, columnsB];

    for(int i = 0; i < rowsA; i++)
    {
        for(int j = 0; j < columnsB; j++)
        {
            for(int k = 0; k < columnsA; k++)
            {
                result[i, j] += mtrA[i,k] * mtrB[k,j];
            }
        }
    }

    return result;
}

int[,] matrixA = CreateMatrixRndInt(3, 4, 0, 10);
int[,] matrixB = CreateMatrixRndInt(4, 4, 0, 10);
if(!ValidationOfThePossibilityOfMatrixMultiplication(matrixA, matrixB))
{
    Console.WriteLine("Невозможно выполнить умножение матриц: количество столбцов матрицы A не совпадает с количеством строк матрицы B.");
    return;   
}
int[,] matricesMultiplication = MatricesMultiplication(matrixA, matrixB);
PrintMatrix(matricesMultiplication);