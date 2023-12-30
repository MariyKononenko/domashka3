//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы./
int[] GenerateArray(int size, int leftRange, int rightRange){
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i<size; i++){
        array[i] = rand.Next(leftRange, rightRange+1);
    }
    return array;
    }


void PrintArray(int[]arrayForPrint){
   for(int i = 0; i<arrayForPrint.Length; i++)
        Console.Write(arrayForPrint[i]+" ");  
}

int Mussiv(int[]myArray, int i){
    
int Lengt = myArray.Length;
        if(i<Lengt/2){

        int temp = myArray[i];
        myArray[i]= myArray[(Lengt - 1)-i];
        myArray[(Lengt - 1) - i] = temp;
        i++;
        Mussiv(myArray, i);
        }
        return myArray[i];
}   

int[] myArray = GenerateArray(10, 1, 100);
PrintArray(myArray);
Console.Write($"Массив:{Mussiv(myArray)}");


