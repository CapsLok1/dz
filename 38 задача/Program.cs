Console.WriteLine("Введите размерность");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];
GetRandomArr(array);
Console.WriteLine($"[{String.Join(" ", array)}]");
Console.WriteLine($"Разница = {DoDifference(array)}");
void  GetRandomArr(int[] quan)
{
    for (int i=0; i<quan.Length;i++)
    {
        quan[i] = new Random().Next(-100, 101);
    }
}

int  DoDifference(int[] array){
    int min = array[0];
    int max = array[0];
    foreach(var item in array){
        if (min>item) min = item;
        if (max<item) max = item;

    }
    return max-min;
}

