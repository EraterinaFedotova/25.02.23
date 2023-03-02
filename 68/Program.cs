// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Она принимает два неотрицательных целых числа в качестве параметров 
// и возвращает натуральное число, обозначается A(n, m).

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine($"Функция Аккермана = {Akkerman(m, n)}");

int Akkerman(int i, int k)
{
  if (i == 0) return k + 1;
  else if (k == 0) return Akkerman(i - 1, 1);
  else return Akkerman(i - 1, Akkerman(i, k - 1));
}