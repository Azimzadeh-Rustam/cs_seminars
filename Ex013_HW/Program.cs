// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ShowThirdDigit(int num)
{
    while(num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool Validate(int num)
{
    if(num < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
        return false;
    }
    else
    {
        return true;
    }
}

int number = Prompt("Введите число: ");
if(Validate(number))
{
    Console.WriteLine(ShowThirdDigit(number));
}