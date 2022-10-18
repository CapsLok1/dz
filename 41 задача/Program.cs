Console.WriteLine("Введите размерность");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];
GetRandomArr(array);
Console.WriteLine($"[{String.Join(" ", array)}]");
Console.WriteLine($"всего натуралыных чисел в данном массиве - {GetNaturalsNumberas(array)}");
void  GetRandomArr(int[] quan)
{
    for (int i=0; i<quan.Length;i++)
    {
        quan[i] = new Random().Next(-100, 101);
    }
}

int GetNaturalsNumberas(int[] array){
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
    return sum;
}