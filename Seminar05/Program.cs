
string words = Console.ReadLine();
string[] nums = words.Split(" ");

using System;
// string words = Console.ReadLine();
// Console.WriteLine(words);
// string[] nums = words.Split(",");
// int index = new Random().Next(0,nums.Length);
// Console.WriteLine(nums[index]);
// Console.WriteLine(String.Join(" ",nums));
/* Напишите программу замена элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.*/
int[] CreatorArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}
int[] NumberArray(int[] array)
{
    foreach (var item in array)
    {
        item*=-1;
    }
    return array;
}

using System;
// string words = Console.ReadLine();
// Console.WriteLine(words);
// string[] nums = words.Split(",");
// int index = new Random().Next(0,nums.Length);
// Console.WriteLine(nums[index]);
// Console.WriteLine(String.Join(" ",nums));
/* Напишите программу замена элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.*/
int[] CreatorArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}
int[] NumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;
    }
    return array;
}
int[] array = CreatorArray(8,-10,11);
Console.WriteLine(String.Join(" ",array));
array = NumberArray(array);
Console.WriteLine(String.Join(" ",array));

bool FindNumber(int number, int[] array)
{
    foreach (var item in array)
    {
        if(item == number) 
        {
            return true;
        }
    }
    return false;
}
int[] array = CreatorArray(8,-10,11);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(FindNumber(1,array));
