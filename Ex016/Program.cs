// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом ругого.

bool CheckSquareTwoNumbers(int num1, int num2)
{
    return num1*num1 == num2 || num2*num2 == num1;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
bool result = CheckSquareTwoNumbers(firstNumber, secondNumber);
Console.WriteLine(result? "Является" : "Не является");