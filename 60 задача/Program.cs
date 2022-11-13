// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Write("Введите размеры массива через пробел ");
string[] nums = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]) , int.Parse(nums[2]) } , 10 , 99);
PrintArray(array);

int[,,] GetArray(int[] sizes , int min , int max){
    int[,,]result = new int[sizes[0], sizes[1] , sizes[2]];
    for (int i = 0 ; i<result.GetLength(0) ; i++){
        for (int j = 0 ; j<result.GetLength(1) ; j++){
            int t = 0;
            while(t < result.GetLength(2)){
                int element = new Random().Next(min , max +1 );
                if ( FindElement(result , element)) continue;
                result[i , j , t] = element;
                t++;

                    
                
            }

        }
    }
    return result;
}

bool FindElement(int[,,] array , int elem){
    for (int i = 0 ; i<array.GetLength(0) ; i++){
        for (int j = 0 ; j<array.GetLength(1) ; j++){
            for ( int t = 0 ; t<array.GetLength(2) ; t++ ){
                if(array[i , j , t] == elem) return true;
            }
        }
    }
    return false;
        
            

            
}   

void PrintArray(int [,,] array){
     for (int i = 0 ; i<array.GetLength(0) ; i++){
        for (int j = 0 ; j<array.GetLength(1) ; j++){
            for ( int t = 0 ; t<array.GetLength(2) ; t++ ){
                Console.Write($"{array[i,j,t]} ({i},{j},{t})  ");
            } Console.WriteLine();
            
        } Console.WriteLine();
        
     }
       
           
}
     
 



