// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите размерность массива (стороки): ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива (столбцы): ");
int col = int.Parse(Console.ReadLine()!);

int[,] arr = GetArray(line, col );


PrintArray(arr);
Console.WriteLine();
SortToLowe(arr);
Console.WriteLine();
PrintArray(arr);


// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLowe(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(1) - 1; t++)
            {
                if (array[i, t] < array[i, t + 1])
                {
                    int temp = array[i, t + 1];
                    array[i, t + 1] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}





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