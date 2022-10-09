// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число больше 0 ");
int a = int.Parse(Console.ReadLine()!);
int b = 1;
if (a <= 0){
    Console.WriteLine("неверное число");
}else
{
    while (b<=a){
    Console.Write($"{Math.Pow(b , 3)}, ");
    b++;
    }
Console.Write($"{Math.Pow(b , 3)} ");
}