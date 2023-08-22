// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Validation (int number)
{
    return number > 9999 && number < 100000 ? true : false;
}

void IsPalindrome(int number)
{
    if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10) Console.WriteLine("Это палиндром");
    else Console.WriteLine("Это не палиндром");
}

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (Validation(n)) IsPalindrome(n);
else Console.WriteLine("Число не пятизначное");