﻿// 08. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Ведите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if(number >= 0){
    if (number >= 2){
        while(count <= number){
            Console.Write($"{count} ");
            count+=2;
        }
    } else{
    Console.WriteLine("Слишком маленькое число");
    }
} else{
    Console.WriteLine("Число не может быть отрицательным");
}