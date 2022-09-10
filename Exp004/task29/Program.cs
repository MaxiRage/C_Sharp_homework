/*Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите числа в формате X, X, ... X ");
string nums = Console.ReadLine();
Console.WriteLine("[{0}]", string.Join(", ", Array(nums)));

string[] Array(string nums)
{
    string[] tmp = nums.Split(", ");
    return tmp;
}