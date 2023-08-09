// 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool CheckDay(int num)
{
    return num > 5? true : false;
}

bool Validation(int num)
{
    return num > 0 && num < 8? false : true;
}

int number = Prompt("Введите день недели: ");
while(Validation(number))
{
    number = Prompt("Такого дня недели не существует. Пожалуйста, повторите попытку: ");
}
if(CheckDay(number))
{
    Console.WriteLine("Ура, это выходной!");
}
else
{
    Console.WriteLine("Придётся поработать...");
}