// 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины. (Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон).

bool ExistenceOfTriangle(int sideA, int sideB, int sideC)
{
    return sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB;
}

Console.WriteLine("Введите стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
bool answer = ExistenceOfTriangle(a, b, c);
Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} существовать {(answer ? "может" : "не может")}");