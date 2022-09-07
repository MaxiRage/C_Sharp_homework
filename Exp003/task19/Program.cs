/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
*/
Console.WriteLine("Введите пятизначное число: ");
int numberA = int.Parse(Console.ReadLine());

if (numberA > 9999 && numberA < 100000)
{
    isPalindrome(numberA);
}
else
{
    Console.WriteLine("Это не пятизначное число");
}

void isPalindrome(int num)
{
    int left = num;
    int rev = 0;
    while (left > 0)
    {
        int r = left % 10;
        rev = rev * 10 + r;
        left = left / 10;
    }
    if (num == rev)
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}