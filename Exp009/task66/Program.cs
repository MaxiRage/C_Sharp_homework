/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(sumNaturalNumbs(m, n));

int sumNaturalNumbs(int m, int n)
{
    int sum = 0;

    if (n == m)
    {
        return n;
    }
    else
    {
        sum += n;
        n--;
        sum += sumNaturalNumbs(m, n);
    }
    return sum;
}