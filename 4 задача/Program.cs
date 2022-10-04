// задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
double a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
double b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
double c = int.Parse(Console.ReadLine()!);
if (a>b & a>c){
    Console.WriteLine($"max - {a}");
}else if (b>c & b>a){
     Console.WriteLine($"max - {b}");
}else if (c>b & c>a){
    Console.WriteLine($"max - {c}");
}else if (a==b & a==c & b==c){
    Console.WriteLine($"max - {a} , {b} , {c}");
}