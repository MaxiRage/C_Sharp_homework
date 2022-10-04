/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Random random = new Random();

Console.WriteLine();
int[,] arr2DInt = new int[4, 4];
int rowsArr2DInt = arr2DInt.GetUpperBound(0) + 1;    // количество строк
int columnsArr2DInt = arr2DInt.Length / rowsArr2DInt;        // количество столбцов
int[] temp = new int[rowsArr2DInt];


Console.WriteLine("Заполняем массив:");
for (int i = 0; i < rowsArr2DInt; i++)
{
    int tmpAmount = 0;
    for (int j = 0; j < columnsArr2DInt; j++)
    {
        arr2DInt[i, j] = random.Next(10);
        Console.Write(arr2DInt[i, j] + " ");
        tmpAmount += arr2DInt[i, j];
    }
    // Console.Write (" = " + tmpAmount);  - если нужна сумма строки
    temp[i] = tmpAmount;
    Console.WriteLine();
}
Console.WriteLine("Номер строки с наименьшей суммой элементов" + " " + minIndInArray(temp));

int minIndInArray(int[] arr)
{
    int minInd = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minInd = i;
        }
    }
    return minInd;
}
    Console.WriteLine();