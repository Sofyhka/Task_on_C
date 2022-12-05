/*Console.Clear();
Console.WriteLine("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Резудьтат: {(n + 1)/ 2 * n}");
*/
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result =1;
for (int i = 1; i <= n; i++)
     result *=i;
Console.WriteLine($"Результат: {result}");