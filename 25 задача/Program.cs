// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

 Console.WriteLine("введите число A");
 int number = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("введите число B");
 int number2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"число {number} в степени числа {number2} = {GetDegree(number,number2)}");



 int GetDegree(int a ,int b){
     int result = 1;
     for(int i = 1 ; i <= b ; i++){
         result = result*a;
     }
     return result;
 }
