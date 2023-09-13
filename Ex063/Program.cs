// 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validation(int num)
{
    return num < 1;
}

void NaturalNumbers(int num)
{
    if(num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

int number = Prompt("Введите целочисленное число: ");

while(Validation(number))
{
    number = Prompt("Неверно введено число. Введите целочисленное число: ");
}

NaturalNumbers(number);