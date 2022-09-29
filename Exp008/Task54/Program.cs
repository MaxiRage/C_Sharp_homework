/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Random random = new Random();

Console.WriteLine();
int[,] arr2DInt = new int[3, 4];
int rowsArr2DInt = arr2DInt.GetUpperBound(0) + 1;    // количество строк
int columnsArr2DInt = arr2DInt.Length / rowsArr2DInt;        // количество столбцов
int[] temp = new int[columnsArr2DInt];

Console.WriteLine("Заполняем массив:");
for (int i = 0; i < rowsArr2DInt; i++)
{
    for (int j = 0; j < columnsArr2DInt; j++)
    {
        arr2DInt[i, j] = random.Next(10);
        temp[j] = arr2DInt[i, j];
        Console.Write(arr2DInt[i, j] + " ");
    }
    Console.WriteLine();

    sortArr(temp);

    for (int j = 0; j < columnsArr2DInt; j++)
    {
        arr2DInt[i, j] = temp[j];
    }
}

int[] sortArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int index = minIndInArray(arr, i);
        int tmp = arr[i];
        arr[i] = arr[index];
        arr[index] = tmp;
    }
    return arr;
}

int minIndInArray(int[] arr, int start)
{
    int minInd = start;
    int min = arr[start];
    for (int i = start; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minInd = i;
        }
    }
    return minInd;
}

Console.WriteLine("Упорядочиваем строки массива:");
for (int i = 0; i < rowsArr2DInt; i++)
{
    for (int j = 0; j < columnsArr2DInt; j++)
    {
        Console.Write(arr2DInt[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();