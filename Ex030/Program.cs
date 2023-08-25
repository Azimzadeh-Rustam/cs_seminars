// 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void FillArr(int[] mass)
{
    int i = 0;
    var random = new Random();
    while(i < mass.Length)
    {
        mass[i] = random.Next(2);
        i++;
    }
}

void PrintArr(int[] mass)
{
    int i = 0;
    while(i < mass.Length)
    {
        Console.Write($"{mass[i]} ");
        i++;
    }
}

int[] array = new int[8];
FillArr(array);
PrintArr(array);