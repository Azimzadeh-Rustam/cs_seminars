// 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void WriteTableSquare(int number)
{
    int i = 1;
    while(i <= number)
    {
        //if(i > 3) return;
        Console.WriteLine($"{i, 3} -> {i*i, 5}");
        i++;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

WriteTableSquare(n);