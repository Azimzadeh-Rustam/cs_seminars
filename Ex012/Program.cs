// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если первое число не кратно второму, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int remainder = firstDigit % secondDigit;
string result = remainder == 0? "Кратно" : $"Не кратно, остаток {remainder}";

Console.Write(result);