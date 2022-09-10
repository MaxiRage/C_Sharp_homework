/*Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите числа в формате X, X, ... X ");
string nums = Console.ReadLine();

Console.WriteLine("=====================================");

Console.WriteLine("[{0}]", string.Join(", ", ToArrayInt(nums)));
Console.WriteLine("Cреднее арифметическое = " + Average(ToArrayInt(nums)));
Console.WriteLine("Максимальное число = " + isMax(ToArrayInt(nums)));
Console.WriteLine("Все числа чётные? - " + isEven(ToArrayInt(nums)));
Console.WriteLine("Числа идут по возрастанию? - " + isIncrement(ToArrayInt(nums)));

Console.WriteLine("=====================================");

int[] ToArrayInt(string nums)
{
    string[] tmp = nums.Split(", ");
    int[] numsArr = Array.ConvertAll(tmp, int.Parse);
    return numsArr;
}

/*
Напишите функцию, которая находит среднее арифметическое чисел в массиве. Среднее арифметическое равно сумме, делёной на количество.
*/
int Average(int[] nums)
{
    int avr = 0;
    foreach (var items in nums)
    {
        avr += items;
    }
    return avr / nums.Length;
}

/*
Напишите функцию, которая принимает массив и находит в нём наибольший элемент. Используйте накопительную переменную. 
Эта переменная изначально равна первому элементу массива; когда встречается лучший кандидат на максимум, она его запоминает.
*/
int isMax(int[] nums)
{
    int max = nums[0];
    foreach (var items in nums)
    {
        if (max < items)
        {
            max = items;
        }
    }
    return max;
}

/*
Напишите функцию, которая проверяет, верно ли, что все числа в массиве чётные. Наличие хотя бы одного нечётного числа означает, что ответ — нет.
*/
bool isEven(int[] nums)
{
    bool check = true;
    foreach (var items in nums)
    {
        if (items % 2 != 0)
        {
            check = false;
            break;
        }
    }
    return check;
}
/*Напишите функцию, которая проверяет, верно ли, что числа в массиве идут по возрастанию. Если очередное число меньше предыдущего, ответ — нет.
*/
bool isIncrement(int[] nums)
{
    bool check = true;
    int chekNum = nums[0];
    foreach (var items in nums)
    {
        if (chekNum > items)
        {
            check = false;
            break;
        }
    }
    return check;
}