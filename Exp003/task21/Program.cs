
/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты первой точки в формате X,X,X ");
string coord = Console.ReadLine();
Console.WriteLine("Введите координаты второй точки в формате X,X,X ");
coord +="," + Console.ReadLine();
Console.WriteLine("-------------");

string [] str = coord.Split(",");
int [] points = Array.ConvertAll(str, int.Parse);

double disatnce = Math.Sqrt(Math.Pow(points[3] - points[0], 2) + Math.Pow(points[4] - points[1], 2) + Math.Pow(points[5] - points[2], 2));

Console.WriteLine("Расстояние между точками = " + Math.Round(disatnce, 2));