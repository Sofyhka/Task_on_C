Console.
Console.Write("Введите любое число")
int number = ReadInt("Введите число N: ");
for (int i = 1; i <= number; i++)
{
    Console.Write($"{i*i*i} ");
}
