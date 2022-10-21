// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.  654 -> 5,  32679 -> 6,  78 -> третьей цифры нет.

Console.Clear();
Console.Write("Введите ваше число:  ");
int number = int.Parse(Console.ReadLine() ?? "0");

int copy = number;

if (number <= 99)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    while (copy > 1000)
    {
        copy = copy / 10;
    }
    Console.WriteLine($"{number} - > {copy%10}");
}