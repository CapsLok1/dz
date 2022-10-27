// Задача 50

Console.Write("Введите строку элемента: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец элемента: ");
int n = int.Parse(Console.ReadLine()!);
double[,] Array = GetArray();
PrintArray(Array);
Console.WriteLine();

if (m > 11 || n > 11)
{
    Console.WriteLine("Такого элемента нет");
}
else {

    Console.WriteLine(Array[m-1,n-1]);
}

double[,] GetArray()
{
    double[,] result = new double[10,10];
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j<10; j++)
        {
            result[i,j] = new Random().Next(21);
        }
    }
    return result;
}
void PrintArray (double[,] Array)
{
    for (int i =0;i<Array.GetLength(0);i++)
    {
        for (int j =0;j<Array.GetLength(1);j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

