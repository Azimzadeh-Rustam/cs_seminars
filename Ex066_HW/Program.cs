// Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ValidationIfNatural(int num)
{
    while(num < 1)
    {
        num = Prompt("Неверно введено число. Введите натуральное число: ");
    }
    return num;
}

int SumBetween(int from, int to)
{
    if(from == to)
    {
        return from;
    }
    else
    {
        if(from > to)
        {
            int temp = from;
            from = to;
            to = temp;
        }
        checked
        {
            return from + SumBetween(from + 1, to);
        }
    }    
}

int numberM = ValidationIfNatural(Prompt("Введите натуральное число M: "));
int numberN = ValidationIfNatural(Prompt("Введите натуральное число N: "));

int sum = SumBetween(numberM, numberN);
Console.WriteLine($"Сумма между числами {numberM} и {numberN} равна {sum}");