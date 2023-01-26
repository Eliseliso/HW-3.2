// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void GetDist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2) * 1.0);
    Console.Write(dist);
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Ввод данных от пользователях x,y,z
double x1 = GetNum("Введите значение x1");
double y1 = GetNum("Введите значение y1");
double z1 = GetNum("Введите значение z1");
double x2 = GetNum("Введите значение x2");
double y2 = GetNum("Введите значение y2");
double z2 = GetNum("Введите значение z2");
Console.Write("Расстояние ");
// определить расстояние 
GetDist(x1, y1, z1, x2, y2, z2);
// вывод
