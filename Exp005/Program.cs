/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Random random = new Random();

Console.WriteLine();

int[] nums = new int[random.Next(5, 15)];
int countEven = 0;
Console.WriteLine("Заполняем массив:");
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = random.Next(100, 1000);
    Console.Write(nums[i] + " ");
    if (nums[i] % 2 == 0)
    {
        countEven++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество чётных чисел = " + countEven);

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine();
int[] numsArr = new int[random.Next(5, 15)];
int sumOddIndex = 0;
Console.WriteLine("Заполняем массив:");
for (int i = 0; i < numsArr.Length; i++)
{
    numsArr[i] = random.Next(1000);
    Console.Write(numsArr[i] + " ");
    if (i % 2 != 0)
    {
        sumOddIndex += numsArr[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма элементов на нечётных позициях = " + sumOddIndex);

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine();

double[] doubleArr = new double[random.Next(5, 15)];
double max = 0;
double min = 0;

Console.WriteLine("Заполняем массив вещественных чисел:");
for (int i = 0; i < doubleArr.Length; i++)
{
    doubleArr[i] = random.NextDouble() * 1000;
    if (i == 0)
    {
        max = doubleArr[i];
        min = doubleArr[i];
    }
    else
    {
        if (max < doubleArr[i])
        {
            max = doubleArr[i];
        }
        if (min > doubleArr[i])
        {
            min = doubleArr[i];
        }
    }
    Console.Write(Math.Round(doubleArr[i], 2) + " ");
}

Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + Math.Round((max - min), 2));
Console.WriteLine();