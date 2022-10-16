 Console.WriteLine($"Массив состоящий из 8 элементов с рандомными числами от 0 до 1000: [{String.Join(", " , DoArr())}]");
// создаем метод, который может вывести массив
 int[] DoArr()
 {
     int[] result = new int[8];
     for (int i=0; i<8;i++)
     {
         result[i] = new Random().Next(1001);
     }
     return result;
 }