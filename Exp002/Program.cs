// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число ");
string nums = Console.ReadLine();
char[] chars = nums.ToCharArray();
Console.WriteLine (chars[1]);

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
string numThree = Console.ReadLine();
char[] ch = numThree.ToCharArray();
if(ch.Length < 3) 
{
    Console.WriteLine ("Третьего числа нет");
}
else
{
Console.WriteLine (ch[2]);
}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число");
int  week = Convert.ToInt32(Console.ReadLine());
if (week == 6 || week == 7)
{
    Console.WriteLine ("Да");
}
else{
Console.WriteLine ("Нет");
}