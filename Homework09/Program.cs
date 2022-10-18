// Homework 09

// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void PrintRealNumber(int num)
{
    Console.WriteLine(num);
    if (num > 1) PrintRealNumber(--num);
}

void Task64()
{
    Console.WriteLine("Задача 64");
    Console.Write("Введите значение N: ");
    int num = Convert.ToInt32(Console.ReadLine());
    PrintRealNumber(num);
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumInInterval(int firstValue, int secondValue)
{
    if (firstValue == secondValue) return firstValue;
    else
    {
        firstValue++;
        return SumInInterval(firstValue, secondValue) + (firstValue - 1);
    }
}

void Task66()
{
    Console.WriteLine("Задача 66");
    Console.Write("Введите значение M: ");
    int mValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int nValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Результат суммы от {mValue} и до {nValue}: {SumInInterval(mValue, nValue)}");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Ackermann(int mValue, int nValue)
{
    if (mValue == 0) return nValue + 1;
    else if (nValue == 0) return Ackermann(mValue - 1, 1);
    return Ackermann(mValue - 1, Ackermann(mValue, nValue - 1));
}

void Task68()
{
    Console.WriteLine("Задача 68");
    Console.Write("Введите значение M: ");
    int mValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int nValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Результат вычисления функции Аккермана: {Ackermann(mValue, nValue)}");
}

// Execute tasks -----------------------------------------------------------------------------
Console.Clear();
Task64();
Console.WriteLine();
Task66();
Console.WriteLine();
Task68();
