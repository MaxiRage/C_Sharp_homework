/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("-------------");
int cube = 1;

while (cube <= numberA)
{
    Console.Write(cube * cube * cube + " ");
    cube++;

}
