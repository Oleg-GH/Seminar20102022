// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.  456 -> 5

Console.Clear();
Console.Write("ВВедите число от 100 до 999:  ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number > 99 && number < 1000)
{
    int second = number / 10 % 10;
    Console.WriteLine($"{number} -> {second}");
}
else
    Console.WriteLine("Введено некорректное значение");

