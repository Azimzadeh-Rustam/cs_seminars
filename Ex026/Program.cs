// 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Check(int n)
{
    int count = 0;
    if(n==0) return 1;
    while(n != 0)
    {
        n /= 10;
        count++;
    }
    return count;
}

int number = Prompt("Введите число: ");
Console.WriteLine($"В числе {number} - {Check(number)} цифр");