// 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string CoordinateRange(int number)
{
    if(number == 1) return "(x > 0, y > 0)";
    if(number == 2) return "(x < 0, y > 0)";
    if(number == 3) return "(x < 0, y < 0)";
    if(number == 4) return "(x > 0, y < 0)";
    return null;
}

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = CoordinateRange(quarter);
Console.WriteLine(result != null ? $"Указанная четверть соответствует диапазону {result}" : "Введены некорректные данные");