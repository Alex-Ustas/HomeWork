// Homework 08

// Общие методы -------------------------------------------------------

int[,] CreateTwoDimensionalArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        Console.WriteLine($"Введите числа в строке {i + 1}:");
        for (int j = 0; j < col; j++)
        {
            Console.Write($"Число в колонке {j + 1}: ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] ArrangeTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPos = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPos]) maxPos = k;
            }
            int countVal = array[i, j];
            array[i, j] = array[i, maxPos];
            array[i, maxPos] = countVal;
        }
    }
    return array;
}

void Task54()
{
    Console.WriteLine("Задача 54");
    Console.Write("Введите количество строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    array = CreateTwoDimensionalArray(rows, columns);
    array = ArrangeTwoDimensionalArray(array);
    PrintTwoDimensionalArray(array);
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка

void MinSumInArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumInRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInRow += array[i, j];
        }
        sumArray[i] = sumInRow;
    }

    Console.WriteLine("Сумма чисел по рядам:");
    for (int i = 0; i < sumArray.Length; i++)
    {
        Console.WriteLine($"{sumArray[i]} ");
    }

    int minRow = 0;
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < sumArray[minRow]) minRow = i;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой: {minRow + 1}");
}

void Task56()
{
    Console.WriteLine("Задача 56");
    Console.Write("Введите размерность массива: ");
    int elements = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[elements, elements];
    array = CreateTwoDimensionalArray(elements, elements);
    PrintTwoDimensionalArray(array);
    Console.WriteLine();
    MinSumInArray(array);
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            int multySum = 0;
            for (int k = 0; k < multMatrix.GetLength(1); k++)
            {
                multySum += matrix1[i, k] * matrix2[k, j];
            }
            multMatrix[i, j] = multySum;
        }
    }
    return multMatrix;
}

void Task58()
{
    Console.WriteLine("Задача 58");
    Console.Write("Введите размер матрицы: ");
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("--- Матрица 1 ---");
    int[,] matrix1 = new int[size, size];
    matrix1 = CreateTwoDimensionalArray(size, size);
    PrintTwoDimensionalArray(matrix1);

    Console.WriteLine("--- Матрица 2 ---");
    int[,] matrix2 = new int[size, size];
    matrix2 = CreateTwoDimensionalArray(size, size);
    PrintTwoDimensionalArray(matrix2);

    int[,] resultMatrix = new int[size, size];
    resultMatrix = MultiplyMatrix(matrix1, matrix2);
    Console.WriteLine("--- Результирующая матрица ---");
    PrintTwoDimensionalArray(resultMatrix);
}

// ""По желанию""
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckItemInArray(int[,,] array, int item)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                if (item == array[i, j, k] || item < 10 || item > 99) return true;
            }
        }
    }
    return false;
}

int[,,] CreateThreeDimensionalArray()
{
    int[,,] array = new int[2, 2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.WriteLine($"Первое измерение = {i + 1}, второе измерение = {j + 1} ");
            for (int k = 0; k < 2; k++)
            {
                while (true)
                {
                    Console.Write($"Введите числа в третьем измерении {k + 1}: ");
                    int item = Convert.ToInt32(Console.ReadLine());
                    if (CheckItemInArray(array, item))
                    {
                        Console.WriteLine("Это число уже есть в массиве или оно не двузначное. Введите другое.");
                    }
                    else
                    {
                        array[i, j, k] = item;
                        break;
                    }
                }
            }
        }
    }
    return array;
}

void ShowIndexInArray(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.Write($"{array[i, j, k]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

void Task60()
{
    Console.WriteLine("Задача 60");

    int[,,] array = new int[2, 2, 2];
    array = CreateThreeDimensionalArray();

    Console.WriteLine("--- Результирующая матрица ---");
    ShowIndexInArray(array);
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] array)
{
    int count = 1;
    int i = 0;
    int j = 0;

    while (count <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Task62()
{
    Console.WriteLine("Задача 62");

    Console.Write("Ведите количество строк: ");
    int rows = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Ведите количество столбцов: ");
    int cols = int.Parse(Console.ReadLine() ?? "0");

    int[,] spiralArray = new int[rows, cols];
    FillSpiralArray(spiralArray);
    PrintSpiralArray(spiralArray);
}


Console.Clear();
Task54();
Console.WriteLine();
Task56();
Console.WriteLine();
Task58();
Console.WriteLine();
Task60();
Console.WriteLine();
Task62();
