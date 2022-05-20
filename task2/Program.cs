/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System;
Console.Clear();


int m = 4;
int n = 8;
Console.WriteLine(SumNamber(m,n));

static int SumNamber(int start, int fin)
{
    if(start==fin) return start;
    return start+SumNamber(start+1,fin);
}


