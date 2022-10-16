// Seminar 08

using System;
using System.Linq;

bool FindElement(int element, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                if(array[i,j,z] == element) return true;
            }
        }
    }
    return false;
}
// 3 5 6
int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,,] baseArray = new int[size[0],size[1],size[2]];
for (int i = 0; i < baseArray.GetLength(0); i++)
{
    for (int j = 0; j < baseArray.GetLength(1); j++)
    {
        int k = 0;
        while (k < baseArray.GetLength(2))
        {
            int rnd = new Random().Next(10, 1000);
            if(!FindElement(rnd,baseArray))
            {
                baseArray[i,j,k] = rnd;
                k++;
            }
        }
    }
}
PrintArray(baseArray);
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} = {i},{j},{k}");
            }
            //Console.WriteLine();
        }
    }

}
