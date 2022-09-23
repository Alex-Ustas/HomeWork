// Homework 03

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int PolyNumber(int number)
{
    if (number < 0) number *= -1;
    if (number < 10000 || number > 999999) return -1;
    if ((number / 10000 == number % 10) &&              // first digit = last digit
        (number / 1000 % 10 == number % 100 / 10))      // second digit = penultimate digit
        return 1;
    return 0;
}

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) +
           Math.Pow(y1 - y2, 2) +
           Math.Pow(z1 - z2, 2)), 2);
}

// Задача 23: Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void Cubes(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.Clear();

Console.Write("Задача 19. Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int result = PolyNumber(num);
if (result == -1)
{
    Console.WriteLine("Введено неверное число");
}
else if (result == 0)
{
    Console.WriteLine("Число " + num + " не является полиндромом");
}
else
{
    Console.WriteLine("Число " + num + " является полиндромом");
}
Console.WriteLine();

Console.WriteLine("Задача 21. Введите координаты двух точек");
Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine("Расстояние между точками: " + Distance(x1, y1, z1, x2, y2, z2));
Console.WriteLine();

Console.Write("Задача 23. Введите число N: ");
num = int.Parse(Console.ReadLine());
Cubes(num);
Console.WriteLine();

// Задача *. Напишите программу, которая на вход принимает радиус круга и находит его площадь,
// округленную до целого числа, необходимо вывести максимальную цифру в полученном округленном
// значении площади круга
// 10 -> 4
// 20 -> 7
// 30 -> 8
int MaxDigitInCircleArea(int radius)
{
    // S = piR^2
    int s = (int)Math.Round(Math.PI * radius * radius, 0);
    int max = 0;
    while (s > 0)
    {
        if (max < s % 10) max = s % 10;
        s /= 10;
    }
    return max;
}

Console.Write("Задача *. Введите радиус круга: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine(MaxDigitInCircleArea(num));
