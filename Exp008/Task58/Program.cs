/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Random random = new Random();

Console.WriteLine();
int[,] matrixOne = new int[2, 2];
int[,] matrixTwo = new int[2, 2];

Console.WriteLine("Заполняем матрицы:");
fillArr(matrixOne);
fillArr(matrixTwo);
Console.WriteLine("Умножаем матрицы:");
int[,] matrixThree = multiMatrix(matrixOne, matrixTwo);

for (int i = 0; i < matrixThree.GetLength(0); i++)
{
    for (int j = 0; j < matrixThree.GetLength(1); j++)
    {
        Console.Write(matrixThree[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] fillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}

int[,] multiMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixThree = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
    {
        for (int i = 0; i < matrixThree.GetLength(0); i++)
        {
            for (int j = 0; j < matrixThree.GetLength(1); j++)
            {
                matrixThree[i, j] = 0;
                for (int n = 0; n < matrixOne.GetLength(1); n++)
                {
                    matrixThree[i, j] += matrixOne[i, n] * matrixTwo[n, j];
                }
            }
        }
    }
    return matrixThree;
}