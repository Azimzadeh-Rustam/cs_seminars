// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ShowSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num - firstDigit * 100 - thirdDigit) / 10;
    return secondDigit;
}

int number = Prompt("Введите трёхзначное число: ");

while(number < 100 || number >= 1000)
{
    number = Prompt("Вы ввели не трёхзначное число. Пожалуйста, повторите ввод: ");
}

Console.WriteLine($"Вторая цифра числа -> {ShowSecondDigit(number)}");