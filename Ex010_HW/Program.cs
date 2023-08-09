// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.s

int ShowSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num - firstDigit * 100 - thirdDigit) / 10;
    return secondDigit;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowSecondDigit(number));