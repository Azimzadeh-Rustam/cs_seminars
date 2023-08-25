// 24.  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNumbers(int A)
{
    int sum = 0;
    int i = 0;
    while(i <= A)
    {
        // Проверка на переполнение типа (Int32)
        checked
        {
            sum += i;
            i++;
        }
    }
    return sum;
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while(number < 1)
{
    Console.Write("Введите число больше единицы: ");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($" Сумма от 1 до {number} равна {SumNumbers(number)}");