Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());//ввод чисел;
int i = n * (-1);
while (i <= n)
{
    Console.Write($"{i}  ");
    i = i+ 1;// i++;
}
