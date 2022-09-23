/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2-> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите числа через пробел");
string tempReadDigits = Console.ReadLine();
string[] strToInt = tempReadDigits.Split(" ");
int countPositiveDigit = 0;

foreach (string check in strToInt)
{
    if ((int.Parse(check) > 0))
    {
        countPositiveDigit++;
    }
}

Console.WriteLine(countPositiveDigit);

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
*/
Console.WriteLine("Введите значения b1, k1, b2 и k2 через пробел");
string tempReadVal = Console.ReadLine();
string[] strToInteger = tempReadDigits.Split(" ");

double x = ((Double.Parse(strToInteger[2]) - Double.Parse(strToInteger[0])) / (Double.Parse(strToInteger[1]) - Double.Parse(strToInteger[3])));
double y = Double.Parse(strToInteger[1]) * x + Double.Parse(strToInteger[0]);

Console.WriteLine("(" + x + ";) (" +  y + ")");