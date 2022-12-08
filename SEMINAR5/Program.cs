void InputArray(int[] array)
{
    for (int i = 0; i < array.Length;i++);
    array[i] = new Random().Next(-9,10);
}
string ReleaseArray(int[] array,int k)
{
    for (int i = 0;i < array.Length;i++)
{
    if (array[i] == k)
    return "yes";
}
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{stringJoin(",")}]");
Console.Write("Введите число которое вы хотите найти в массиве: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));