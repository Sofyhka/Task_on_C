Console.Clear();
Console.Write("введите число ");
int number =int.Parse(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number /=10;
}

Console.WriteLine("Сумма равно {0}" ,sum);
