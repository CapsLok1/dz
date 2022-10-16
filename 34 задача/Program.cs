// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

 int[] arr = DoArr();
 Console.WriteLine($"Массив с рандомными трёхзначными числами: [{String.Join(", ", arr)}], колличество четных чисел: {CheckEvenNumbers(arr)}");
 int[] DoArr()
 {
     int[] result = new int[8];
     for (int i=0; i<8;i++)
     {
         result[i] = new Random().Next(1001);
     }
     return result;
 }
 
  int CheckEvenNumbers(int[] arr){
     int result = 0;
     for (int i=0; i<10;i++){
         result = result%2;
         result++;
     }
     return result;

  } 
