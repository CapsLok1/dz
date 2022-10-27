
// //Задача 47
Console.Write("Введите размерность массива (стороки): ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива (столбцы): ");
int n = int.Parse(Console.ReadLine()!);

double[,] Array = DoArray(m,n);
PrintArray(Array);

double[,] DoArray(int m, int n)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = new Random().NextDouble();
            result[i,j] += new Random().Next(-20,21);
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
            Console.Write($"{(Array[i,j]):f1} ");
        }
        Console.WriteLine();
    }
}
