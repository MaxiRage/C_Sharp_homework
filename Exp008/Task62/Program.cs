/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int m = 4;
int n = 4;

int[,] array2D = new int[m, n];
int running = 1;

//Заполняем периметр массива по часовой стрелке
for (int y = 0; y < n; y++)
{
    array2D[0,y] = running;
    running++;
}
for (int x = 1; x < m; x++)
{
    array2D[x,n - 1] = running;
    running++;
}
for (int y = n - 2; y >= 0; y--)
{
    array2D[m - 1,y] = running;
    running++;
}
for (int x = m - 2; x > 0; x--)
{
    array2D[x,0] = running;
    running++;
}
//Периметр заполнен. Продолжаем заполнять массив и задаём
//координаты ячейки, которую необходимо заполнить следующей.
int c = 1;
int d = 1;

while (running < m * n)
{

    //Движемся вправо
    while (array2D[c,d + 1] == 0)
    {
        array2D[c,d] = running;
        running++;
        d++;
    }

    //Движемся вниз.
    while (array2D[c + 1,d] == 0)
    {
        array2D[c,d] = running;
        running++;
        c++;
    }

    //Движемся влево.
    while (array2D[c,d - 1] == 0)
    {
        array2D[c,d] = running;
        running++;
        d--;
    }

    //Движемся вверх.
    while (array2D[c - 1,d] == 0)
    {
        array2D[c,d] = running;
        running++;
        c--;
    }
}

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array2D[x,y] == 0)
        {
            array2D[x,y] = running;
        }
    }
}

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array2D[x,y] < 10)
        {
            Console.Write(string.Format("{0:d2}"  + " ",array2D[x,y]));
        }
        else
        {
            Console.Write(array2D[x,y] + " ");
        }
    }
    Console.WriteLine();
}