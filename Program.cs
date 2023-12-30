// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int ReadInt(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n){
if(m==0) return n +1;
else
if( n == 0) return Akkerman(m - 1, 1);
    
    else return  Akkerman(m - 1, Akkerman(m, n -1)) ;
  } 


int A = ReadInt("Ввудите первое число ");
int B= ReadInt("Ввудите второе число ");
Console.Write(Akkerman(A, B));