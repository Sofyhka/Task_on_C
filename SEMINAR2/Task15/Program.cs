Console.Clear();
Console.Write("Введите число от 1 до 7: ");
 int a = Convert.ToInt32(Console.ReadLine());
 if (a >= 1 && a <= 7)
 {
    if (a == 6 | a == 7)Console.WriteLine("Сегодня выходной день ");
    else Console.WriteLine("Сегодня рабочий день ");
 }
 else Console.WriteLine("Не верное число ");

