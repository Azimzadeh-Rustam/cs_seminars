// 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void Validation(int num)
{
    while(num < 1)
    {
        num = Prompt("Неверно введено число. Введите целочисленное число: ");
    }
}

int FindSumOfDigits(int num) //453  45  4  0
 {
    if (num == 0) return 0;
    return num % 10 + FindSumOfDigits(num / 10); // Это стэк : 453  45  4
    // 4%10 + 45%10 + 453%10 = 4 + 5 + 3 + 0 (из return) = 12
 }

int number = Prompt("Введите целочисленное число: ");
Validation(number);
Console.WriteLine(FindSumOfDigits(number));