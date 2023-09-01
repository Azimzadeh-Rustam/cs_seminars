// 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double Prompt(string message)
{
    Console.Write(message);
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

bool Validate(double slope1, double indent1, double slope2, double indent2)
{
    if(slope1 == slope2 && indent1 == indent2)
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else if (slope1 == slope2)
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    return true;
}

double FindX(double slope1, double indent1, double slope2, double indent2)
{
    return (indent2 - indent1) / (slope1 - slope2);
}

double FindY(double slope1, double indent1, double slope2, double indent2)
{
    return (indent1 * slope2 - indent2 * slope1) / (slope2 - slope1);
}

double k1 = Prompt("Введите k1: ");
double b1 = Prompt("Введите b1: ");
double k2 = Prompt("Введите k2: ");
double b2 = Prompt("Введите b2: ");
if(Validate(k1, b1, k2, b2))
{
    double xIntersection = FindX(k1, b1, k2, b2);
    double yIntersection = FindY(k1, b1, k2, b2);
    Console.Write($"Прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} пересекаются в точке -> ({xIntersection}, {yIntersection})");
}
