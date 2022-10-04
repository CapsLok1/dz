Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
int i = 1;
Console.WriteLine("все чётные числа в диапозне от 1 до n");
while (i<=n)
{
    if (i%2 ==0){
        Console.WriteLine($"{i}");
    }
    i++;
}