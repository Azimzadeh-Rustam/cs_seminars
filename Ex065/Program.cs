// 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void Validation(int num)
{
    while(num < 1)
    {
        num = Prompt("Неверно введено число. Введите целочисленное число: ");
    }
}

void RangeNaturalNumbers(int from, int to)
{
    if(from < to)
    {
        Console.Write($"{from} ");
        RangeNaturalNumbers(from + 1, to);
    }
    else if(from > to)
    {
        Console.Write($"{from} ");
        RangeNaturalNumbers(from - 1, to);
    }
    else
    {
        Console.Write($"{from}");
    }
}

int numberN = Prompt("Введите целочисленное число N: ");
Validation(numberN);
int numberM = Prompt("Введите целочисленное число M: ");
Validation(numberM);

RangeNaturalNumbers(numberN, numberM);