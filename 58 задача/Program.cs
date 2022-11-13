// Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите размерность  1 массива (стороки): ");
int rowsA  = int.Parse(Console.ReadLine()!);

Console.Write("Введите размерность  1 массива (столбцы): ");
int colA   = int.Parse(Console.ReadLine()!);

Console.Write("Введите размерность  2 массива (стороки): ");
int rowsB  = int.Parse(Console.ReadLine()!);

Console.Write("Введите размерность  2  массива (столбцы): ");
int colB   = int.Parse(Console.ReadLine()!);

if (colA == colB){
    Console.WriteLine("Ошибка . Такие матрицы нельзя умножить  ");
    return;
}

int[,] arrayA = GetArray(rowsA , colA , 0 , 10 );

int[,] arrayB = GetArray(rowsB , colB , 0 , 10 );

PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(GetNewMatrix(arrayA , arrayB));


int[,] GetNewMatrix(int[,] A , int[,] B ){
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0 ; i< arrayA.GetLength(0) ; i++){
        for( int j = 0  ; j < arrayB.GetLength(1) ; j++){
            for ( int t = 0 ; t<arrayA.GetLength(1) ; t++){
                arrayC[i , j] += arrayA[i , t] + arrayB[t , j]; 
            }
        }
    } return arrayC;
}

int[,] GetArray(int m , int n , int min , int max ){
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
