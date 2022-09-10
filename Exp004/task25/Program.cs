/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите 2 числа в формате X, X ");
string nums = Console.ReadLine();
Console.WriteLine(Degree(nums));

int Degree(string nums)
{
    string[] tmp = nums.Split(", ");
    int[] digitArr = Array.ConvertAll(tmp, int.Parse);
    int res = digitArr[0];
    for (int i = 1; i < digitArr[1]; i++)
    {
        res = res * digitArr[0];
    }
    return res;
}
