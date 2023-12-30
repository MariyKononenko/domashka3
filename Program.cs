
 //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурcию.
 
 void PrintNaturalNumbers(int n, int m){
    if(n > m){
        return;
    }

  else{
    Console.Write(n+" ");  
    n++;
    PrintNaturalNumbers(n,m);
 }
 }
 Console.WriteLine("Введите число n");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число m");
 int m = Convert.ToInt32(Console.ReadLine());
 PrintNaturalNumbers(n,m);