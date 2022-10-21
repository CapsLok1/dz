
// задача 43

Console.WriteLine("Нахождения точки персечения функций вида y = kx + b");
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);

double x = (b2-b1)/(k1-k2);
double y = x*k1 + b1;

Console.WriteLine($"Точка пересечений будет в координате ({x}, {y})");