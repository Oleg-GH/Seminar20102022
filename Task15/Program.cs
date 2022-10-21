// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

//Console.Clear();
Console.Write("Введите порядковый номер дня недели от 1 до 7:  ");
int day = int.Parse(Console.ReadLine() ?? "0");

if (day < 1 || day > 7)
{
    Console.WriteLine("Некорректное число, попробуйте снова");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"{day} -> да");
    }
    else
    {
        Console.WriteLine($"{day} -> нет");
    }
}

