// Homework 04

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Power(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Digitresult(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] CreateArray()
{
    int[] numbers = new int[8];
    int count = 0;
    int number = 0;
    while (number != 999 && count < 8)
    {
        Console.Write("Введите число " + (count + 1) + ": ");
        number = int.Parse(Console.ReadLine());
        if (number == 999) break;
        numbers[count] = number;
        count++;
    }
    return numbers;
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.Write("]");
}

Console.Clear();
Console.Write("Задача 25. Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Результат возведения числа A в натуральную степень B: " + Power(a, b));
Console.WriteLine();

Console.Write("Задача 27. Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Сумма цифр в числе: " + Digitresult(num));
Console.WriteLine();

Console.WriteLine("Задача 29. Введите числа в массив (до 8, стоп-число 999)");
int[] numbers = new int[8];
numbers = CreateArray();
PrintArray(numbers);
