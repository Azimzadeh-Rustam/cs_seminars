// 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int MultiplicationNumbers(int A)
{
    int sum = 1;
    int i = 1;
    while(i <= A)
    {
        // Проверка на переполнение типа (Int32)
        checked
        {
            sum *= i;
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
Console.WriteLine($"Произведение от 1 до {number} равна {MultiplicationNumbers(number)}");