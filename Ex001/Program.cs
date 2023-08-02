// 01. Напишите программу, которая на вход принимает число и выдаёт его квадрат.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int squared = number*number;

Console.WriteLine($"{number}^2={squared}");