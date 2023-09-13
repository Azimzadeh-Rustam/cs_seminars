// 60. Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateArr3dRndInt(int rows, int columns, int depth)
{
    int[,,] cubeArr = new int[rows, columns, depth];
    cubeArr[0, 0, 0] = 10;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < depth; k++)
            {
                cubeArr[i, j, k] = cubeArr[0, 0, 0]++;
            }
        }
    }
    return cubeArr;
}

bool ValidationForDoubleDigitsInArr3d(int[,,] cubeArr)
{
    int rows = cubeArr.GetLength(0);
    int columns = cubeArr.GetLength(1);
    int depth = cubeArr.GetLength(2);

    int countOfElements = rows * columns * depth;

    return countOfElements > 89;
}

void PrintArr3dRows(int[,,] cubeArr)
{
    int rows = cubeArr.GetLength(0);
    int columns = cubeArr.GetLength(1);
    int depth = cubeArr.GetLength(2);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < depth; k++)
            {
                Console.Write($"{cubeArr[i, j, k], 5}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array3d = CreateArr3dRndInt(4, 4, 5);
if(ValidationForDoubleDigitsInArr3d(array3d))
{
    Console.WriteLine("Невозможно заполнить массив двухзначными числами, поскольку в массиве слишком много элементов");
    return;   
}
PrintArr3dRows(array3d);