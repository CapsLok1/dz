// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки: ");
  int a1 = int.Parse(Console.ReadLine()!);
  Console.WriteLine("Введите координату y первой точки: ");
  int b1 = int.Parse(Console.ReadLine()!);
  Console.WriteLine("Введите координату z первой точки: ");
  int c1 = int.Parse(Console.ReadLine()!);
  Console.WriteLine("Введите координату x второй точки: ");
  int a2 = int.Parse(Console.ReadLine()!);
  Console.WriteLine("Введите координату y второй точки: ");
  int b2 = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату z второй точки: ");
 int c2= int.Parse(Console.ReadLine()!);

 int A = a1 - a2;
 int B = b1 - b2;
 int C = c1 - c2;

 double len = Math.Sqrt(A * A + B * B + C * C);
 Console.WriteLine($"расстояние между отрезками {len}");

