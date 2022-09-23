// Homework 02

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int MiddleNum(int number)
{
    return number / 10 % 10;
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
string ThirdNum(int number)
{
    if (number < 100)
    {
        return "третьей цифры нет";
    }

    int result = 1; // init dummy number
    while (number > 100)
    {
        result = number % 10;
        number /= 10;
    }
    return result.ToString();
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void IsWeekEnd(int number)
{
    if (number > 5)
    {
        Console.WriteLine(number + "-й день недели - выходной");
    }
    else
    {
        Console.WriteLine(number + "-й день - будний день");
    }
}

Console.Clear();
Console.Write("Задача 10. Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра числа: " + MiddleNum(num));
Console.WriteLine();

Console.Write("Задача 13. Введите число: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("Третья цифра числа: " + ThirdNum(num));
Console.WriteLine();

Console.Write("Задача 15. Введите день недели числом: ");
num = int.Parse(Console.ReadLine());
IsWeekEnd(num);
