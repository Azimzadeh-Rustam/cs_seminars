// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int number = new Random().Next(100,999 + 1);
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int newNumber = DeleteSecondDigit(number);

Console.WriteLine($"{newNumber}");