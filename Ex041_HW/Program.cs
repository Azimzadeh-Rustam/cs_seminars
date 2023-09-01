// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент массива: ");
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

int size = Prompt("Введите размер массива: ");
int[] array = InputArray(size);
int countPositiveNumbers = CountPositiveNumbers(array);
Console.Write("В массиве ");
PrintArray(array);
Console.Write($" -> {countPositiveNumbers} элемента больше нуля");