
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.Write("Введите размерность массива (стороки): ");
int rows  = int.Parse(Console.ReadLine()!);

Console.Write("Введите размерность массива (столбцы): ");
int col = int.Parse(Console.ReadLine()!);

int [,] array =  GetArray(rows , col  , 0 , 10);
PrintArray(array);
Console.WriteLine($"Строка по индексу с наименьшой суммой - {GetRowNumber(array)} ");



int GetRowNumber(int [,] array){
    int row = 0 ;
    int minsum = 0 ; 
    for (int i =0 ; i < array.GetLength(1) ; i++ ){
        minsum  =  minsum +  array[0,i];
    }

    for ( int i = 1 ; i < array.GetLength(0) ; i++){
        int sum = 0;
        for ( int j = 0 ; j < array.GetLength(1) ; j++){
            sum = sum + array[i , j];
        }
        if (minsum > sum){
            minsum = sum;
            row = i;
        }

        
    }
    return row;

}

int [,] GetArray(int n , int m , int min , int max ){
    int[,] result  = new int[m,n];
    for (int i =0 ; i < m ; i++ ){
        for (int j = 0 ; j < n ; j++ ){
             result[i,j] = new Random().Next(min, max + 1) ;
        }
        
    }
    return result;
}


void PrintArray(int[,]InArray){
     for (int i =0 ; i < InArray.GetLength(0) ; i++ ){
        for (int j = 0 ; j < InArray.GetLength(1) ; j++ ){
            Console.Write($"{InArray[i,j]} ");
        }
        Console.WriteLine();
     }
        
}