
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 2 числа: ");
int numOne = Convert.ToInt32(Console.ReadLine());
int numTwo = Convert.ToInt32(Console.ReadLine());
if (numOne > numTwo) Console.WriteLine("Число " + numOne + " больше, а " + numTwo + " меньше!");
else Console.WriteLine("Число " + numTwo + " больше, а " + numOne + " меньше!");


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа: ");
int oneNum = Convert.ToInt32(Console.ReadLine());
int twoNum = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
if (max < oneNum) max = oneNum;
if (max < twoNum) max = twoNum;
Console.WriteLine ("Число " + max + " максимальное!");


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.Write ("Число чётное");
else Console.WriteLine ("Число нечётное");


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < numN; i++) {
    if (i % 2 == 0) Console.Write (i + " ");
}