// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите 1 число  число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 число  число ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($" сумма  нактуральных элементов в  промежутке от M до N : {SumNumbersInterval(a , b )}");

int SumNumbersInterval(int a , int b ){
    if ( a==b) return a;
    return a  + SumNumbersInterval(a + 1, b);
}