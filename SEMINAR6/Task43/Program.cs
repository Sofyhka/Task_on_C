﻿Console.Clear();
Console.WriteLine("введите значение b1");
double b1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("введите значения b2");
double b2 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToUInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($" две прямые пересекутся  в точке с координатами X: {x}, Y: {y}");

