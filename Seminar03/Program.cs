Console.Clear();

int NumberOne(int num, int degree)
{
    while (num / Math.Pow(10, degree) > 1)
    {
        num /= 10;
    }
    return num;
}

int number = int.Parse(Console.ReadLine());

int x = 1, y = 1;

if (number < 0) number *= -1;
if (number > 99)
{
    x = number % 100;
    y = NumberOne(number, 2);
    Console.WriteLine(y + "..." + x);
}
else if (number > 9)
{
    x = number % 10;
    y = NumberOne(number, 1);
    Console.WriteLine(y + "..." + x);
}
else
{
    Console.WriteLine("Error: enter number more than 9");
}

