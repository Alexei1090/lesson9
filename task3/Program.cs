/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29*/

using System;
Console.Clear();


int m = 3;
int n = 2;
Console.WriteLine(Ak(m,n));

static int Ak(int start, int fin)
{
    if(start==0) return fin+1;
    if(fin==0) return Ak(start-1,1);
    return Ak(start-1,Ak(start,fin-1));
}
