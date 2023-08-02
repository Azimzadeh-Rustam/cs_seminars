// 05. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100 && number <= 999) {
    int lastDigit = number % 10;
    Console.Write($"Последняя цифра числа: {lastDigit}");
} else {
    Console.Write("Неверное число");
}