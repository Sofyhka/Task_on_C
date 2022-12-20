
/*
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
        return 0;
    return sum() + x;
}

Console.Clear();
Console.WriteLine(sum());
*/

void rec(int n)
{
    if (n == 1)
        Console.Write(n + " ");
    if (n > 1)
    {    
        rec(n - 1);
        Console.Write(n + " ");
    }
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
rec(n);


