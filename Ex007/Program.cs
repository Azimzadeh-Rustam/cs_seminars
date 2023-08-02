// 07. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Ведите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;

if (number < 0) number *= -1;
while (count <= number){
    Console.Write($"{count} ");
    count += 1;
}