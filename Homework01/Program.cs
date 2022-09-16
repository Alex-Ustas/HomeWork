// Homework 01

Console.Clear();
Console.Write("Укажите номер задания (2, 4, 6, 8): ");
int task = int.Parse(Console.ReadLine());

if (task == 2)
{
    // Задача 2: -----------------------------------------------------------------------------
    // Напишите программу, которая на вход принимает два числа и выдаёт, 
    // какое число большее, а какое меньшее.
    Console.Write("Введите первое число: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = int.Parse(Console.ReadLine());
    if (number1 > number2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else if (number1 < number2)
    {
        Console.WriteLine("Первое число меньше второго");
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}
else if (task == 4)
{
    // Задача 4: -----------------------------------------------------------------------------
    // Напишите программу, которая принимает на вход три числа и 
    // выдаёт максимальное из этих чисел.
    Console.Write("Введите первое число: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = int.Parse(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int number3 = int.Parse(Console.ReadLine());
    int max = number1;

    if (number2 > max)
    {
        max = number2;
    }
    if (number3 > max)
    {
        max = number3;
    }

    Console.WriteLine("Максимальное число: " + max);
}
else if (task == 6)
{
    // Задача 6: -----------------------------------------------------------------------------
    // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
    // (делится ли оно на два без остатка).
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.WriteLine("Число " + number + " является четным");
    }
    else
    {
        Console.WriteLine("Число " + number + " является нечетным");
    }
}
else if (task == 8)
{
    // Задача 8: -----------------------------------------------------------------------------
    // Напишите программу, которая на вход принимает число (N),
    // а на выходе показывает все чётные числа от 1 до N.
    Console.Write("Введите число N: ");
    int number = int.Parse(Console.ReadLine());
    int count = 1;

    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write(count + " ");
        }
        count++;
    }
}
else
{
    Console.WriteLine("Выбран неверный номер задания");
}

