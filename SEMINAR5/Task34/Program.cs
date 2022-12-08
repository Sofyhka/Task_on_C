Console.Clear();
Console.WriteLine("Ведите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;
int i = 0;
for (int b = 0; b < numbers.Length;b++)
if (numbers [b] % 2 == 0)
count++;
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них четные");
void ArrayRandomNumbers (int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++);
}
{
    numbers[i] = new Random().Next(100,1000);
}
void PrintArray(int[] numbers)
{
    Console.Write("  ");
    for(int i = 0; i < numbers.Length;i++)
    {
        Console.Write(numbers[i] + ' ');
    }
}
Console.Write("  ");
Console.WriteLine();