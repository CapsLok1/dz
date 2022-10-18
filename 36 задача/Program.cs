 int size = new Random().Next(1, 10);
 int[] arr = DoRandomArr(size);
 Console.WriteLine($"Kолличество элементов в массиве: {size}");
Console.WriteLine($"Массив с рандомными числами: [{String.Join(", ", arr)}], сумма чисел на нечетных позициях: {sum_uneven(arr)}");
int[] DoRandomArr(int quan)
{
    int[] result = new int[size];
    for (int i=0; i<quan;i++)
    {
        result[i] = new Random().Next(20);
    }
    return result;
}
int sum_uneven (int[] arr)
{
    int result = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (i%2 != 0)
        {
            result+= arr[i];
        }
    }
    return result;
}