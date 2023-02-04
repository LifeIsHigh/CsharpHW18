// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter b1: ");
char b1 = Convert.ToChar(Console.ReadLine());
Console.Write("Enter k1: ");
char k1 = Convert.ToChar(Console.ReadLine());
Console.Write("Enter b2: ");
char b2 = Convert.ToChar(Console.ReadLine());
Console.Write("Enter k2: ");
char k2 = Convert.ToChar(Console.ReadLine());

double X = (k1 * b2 + b1) / (-(k2 * k1 - 1));
double Y = k1 * X + b1;
X = Math.Round(X, 3);
Y = Math.Round(Y, 3);
Console.WriteLine($"point of intersection of lines: ({X}; {Y})");