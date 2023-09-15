// 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int numberM = ValidationIfNatural(Prompt("Введите натуральное число M: "));
int numberN = ValidationIfNatural(Prompt("Введите натуральное число N: "));

int result = Ackermann(numberM, numberN);
Console.WriteLine(result);