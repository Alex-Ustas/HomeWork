// Homework 07

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");
Console.WriteLine();
Console.WriteLine("Введите размер двумерного массива (m*n): ");
var (m, n) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Создание двумерного массива...");
Console.WriteLine();
double[,] array = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++) //метод наполнения двумерного массива
{
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(Convert.ToDouble(rnd.Next(-9, 10)) + rnd.NextDouble(), 1);
        Console.Write(array[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.ReadKey();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, ");
Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Введите размер двумерного массива (m*n): ");
(m, n) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Создание двумерного массива...");
Console.WriteLine();
array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++) //метод наполнения двумерного массива
{
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Введите искомое число в массиве: ");
int searchNum = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == searchNum) 
        {
            count++;
        }
    }
}
if (count == 0) Console.WriteLine("Такого числа в массиве нет!");
else 
{
    Console.WriteLine("Найдено искомое число!");
    Console.WriteLine($"Число {searchNum} найдено {count} раз!");
}
Console.WriteLine();
Console.ReadKey();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("Введите размер двумерного массива (m*n): ");
(m, n) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Создание двумерного массива...");
Console.WriteLine();
array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++) //метод наполнения двумерного массива
{
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine();

double tempSum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSum = tempSum + array[j, i];
    }
    tempSum = Math.Round((tempSum/n), 2);
    Console.Write($"{tempSum}; ");
    tempSum = 0;
}
Console.ReadKey();
