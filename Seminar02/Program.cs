// Functions

void WriteTwo()
{
    Console.WriteLine(2);
}

string Hello(string name)
{
    return "Hello, " + name;
}

Console.Clear();
WriteTwo();
WriteTwo();
WriteTwo();
WriteTwo();

string name = Hello("Alex");
Console.WriteLine(name + ". How are you?");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

// Arrays

// int num = new int[10];
// int a = { 1, 3, 5, 878, 34, 12, 45 };

int[] CreateNumArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = i;
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

int[] numbers = CreateNumArray(10);
WriteArray(numbers);

