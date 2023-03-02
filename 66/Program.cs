//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine($"Cумма натуральных элементов = {SumElements(m, n)}");

int SumElements(int m, int n)
{
    if (m == n)
        return m;
    else
    {
        return m + SumElements(m+1, n);
    }
}
