Console.Clear();
int number = ReadInt("Введите трёхзначное число ");
int amout = number.ToString().Length;
if (amout < 3 || amout > 3)
{
    Console.WriteLine("Вы ввели не трёхзначное число ");
}
else
{
    Console.WriteLine(IntCentr(number));
}
int ReadInt(string message)
{
    Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
int IntCentr(int a)
{
    int result = ((a / 10) % 10);
    return result;
}