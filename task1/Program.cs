/*Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа по убыванию в промежутке от M до N.
M = 1; N = 5. -> "5, 4, 3, 2, 1"

M = 4; N = 8. -> "8, 7, 6, 5, 4"*/

using System;
Console.Clear();

int m = 1;
int n = 5;
string resualt = GetNumbers(m,n);
Console.WriteLine(resualt);


static string GetNumbers(int start, int end)
{
    if(end==start) return end.ToString();
    return(end+" "+GetNumbers(start,end-1));
}
