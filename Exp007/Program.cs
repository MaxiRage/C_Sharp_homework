/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Random random = new Random();

Console.WriteLine();

double[,] arr2D = new double[random.Next(3, 10), random.Next(3, 10)];
int rowsArr2D = arr2D.GetUpperBound(0) + 1;    // количество строк
int columnsArr2D = arr2D.Length / rowsArr2D;        // количество столбцов

Console.WriteLine("Заполняем массив:");
for (int i = 0; i < rowsArr2D; i++)
{
    for (int j = 0; j < columnsArr2D; j++)
    {
        arr2D[i, j] = random.NextDouble() * 1000;
        Console.Write(Math.Round(arr2D[i, j], 2) + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.WriteLine("Введите позицию элемента");
int searchDigit = Convert.ToInt32(Console.ReadLine());

int searchRows = 0;
int searchColumn = columnsArr2D;

if ((rowsArr2D * columnsArr2D) > searchDigit)
{
    while (searchDigit >= searchColumn)
    {
        searchColumn += columnsArr2D;
        searchRows++;
    }

    Console.WriteLine(Math.Round(arr2D[searchRows, searchDigit - searchRows * columnsArr2D], 2));
}
else Console.WriteLine("Такого числа в массиве нет");
Console.WriteLine();
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] arr2DInt = new int[random.Next(3, 10), random.Next(3, 10)];
int rowsArr2DInt = arr2DInt.GetUpperBound(0) + 1;    // количество строк
int columnsArr2DInt = arr2DInt.Length / rowsArr2DInt;        // количество столбцов
double[] avr = new double[columnsArr2DInt];
double tempAvr = 0;

Console.WriteLine("Заполняем массив:");
for (int i = 0; i < columnsArr2DInt; i++)
{
    for (int j = 0; j < rowsArr2DInt; j++)
    {
        arr2DInt[j, i] = random.Next(1000);
        tempAvr += arr2DInt[j, i];
    }
    avr[i] = tempAvr / rowsArr2DInt;
    tempAvr = 0;
}
// Выводим массив
for (int i = 0; i < rowsArr2DInt; i++)
{
    for (int j = 0; j < columnsArr2DInt; j++)
    {
        Console.Write(arr2DInt[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

//Выводим среднее
Console.WriteLine("Среднее арифметическое каждого столбца: ");
foreach (double temp in avr)
{
    Console.Write(Math.Round(temp, 2) + "; ");
}
Console.WriteLine();