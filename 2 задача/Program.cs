 // ; Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// ; a = 5; b = 7 -> max = 7
// ; a = 2 b = 10 -> max = 10
// ; a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число ");
double num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
double num1 = int.Parse(Console.ReadLine()!);

if (num>num1){
    Console.WriteLine($"max - {num}");
}else if (num<num1){
    Console.WriteLine($"max- {num1}");
}else if (num == num1){
    Console.WriteLine($"max - {num} , {num1}");
}