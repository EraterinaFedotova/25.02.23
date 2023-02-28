//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.


Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine($"Cумма чисел = {SumNumbers(m, n)}");

int SumNumbers(int start, int end)
{
    if (start == end) return start;
    return (start + SumNumbers(start + 1, end));
}