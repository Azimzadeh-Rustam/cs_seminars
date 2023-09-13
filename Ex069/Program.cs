// 69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ValidationNaturalNumber(int num)
{
    while(num < 1)
    {
        num = Prompt("Неверно введено число. Введите натуральное число: ");
    }
    return num;
}

int Exponentiation(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * Exponentiation(num1, num2 - 1);
}

int numberOne = Prompt("Введите основание числа: ");
int numberTwo = ValidationNaturalNumber(Prompt("Введите степень числа: "));
Console.WriteLine(Exponentiation(numberOne, numberTwo));