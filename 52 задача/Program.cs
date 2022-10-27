//ввод данных
Console.Write("Введите размерность массива (стороки): ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива (столбцы): ");
int col = int.Parse(Console.ReadLine()!);

int[,] arr = GetArray(line, col);


PrintArray(arr);
Console.WriteLine();
double[] arithmeticMEAN = Get_arithmetic_mean(arr, line, col); 
Console.WriteLine($"Среднее арифметическое столбцов: {String.Join("; ", arithmeticMEAN)}");




int[,] GetArray(int line, int col)
{
    int[,] result = new int[line,col];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j<col; j++)
        {
            result[i,j] = new Random().Next(0,11);
        }
    }
    return result;
}
void PrintArray (int[,] Array)
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

double[] Get_arithmetic_mean (int[,] Arr, int line, int column)
{
    double[] result = new double[column];
    for (int j = 0; j<column; j++)
    {
        for (int i=0;i<line;i++)
        {
            result[j] += Arr[i,j];
        }
        result[j] /= line;
        Math.Floor(result[j]);
    }
    return result;
}