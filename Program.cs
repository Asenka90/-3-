// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("***Задача 19***");
Console.Write("Введи число и программа определит является ли оно палиндромом: ");
string number = Console.ReadLine();
void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"В числе не 5 цифр. Введи правильное число");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("***Задача 21***");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double addition(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}
double cutLength = Math.Round(addition(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Расстояние между точками = {cutLength}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("***Задача 23***");
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
void Cube(int[] n)
{
    int i = 0;
    int length = n.Length;
    while (i < length)
    {
        n[i] = Convert.ToInt32(Math.Pow(i, 3));
        i++;
    }
}
void PrintArry(int[] x)
{
    int count = x.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(x[index] + " ");
        index++;
    }
}
int[] arry = new int[n + 1];
Cube(arry);

PrintArry(arry);