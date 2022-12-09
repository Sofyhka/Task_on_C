Console.Clear();
Console.Write("введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int x, a0 = 0,a1 = 1;
for (int i = 0 ; i < n;i++)
{
    Console.Write($"{a0} ");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}
