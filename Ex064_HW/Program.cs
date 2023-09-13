// 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ValidationNaturalNumber(int num)
{
    while(num < 1)
    {
        num = Prompt("Неверно введено число. Введите натуральное число: ");
    }
    return num;
}

void PrintRangeOf(int num)
{
    if(num < 1) return;
    Console.Write($"{num} ");
    PrintRangeOf(num - 1);
}

int number = Prompt("Введите целое число: ");
number = ValidationNaturalNumber(number);
PrintRangeOf(number);