// 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] mtr)
{
    int rows = mtr.GetLength(0);
    int columns = mtr.GetLength(1);
    int size = mtr.Length;

    int[] arr = new int[size];
    int k = 0;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            arr[k] = mtr[i,j];
            k++;
        }
    }

    return arr;
}

void FrequencyDictionary(int[] arr)
{
    int count = 1;
    int num = arr[0];

    for(int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{num} -> {count}");
            count = 1;
            num = arr[i];
        }
    }
    Console.WriteLine($"{num} -> {count}");
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

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(array);