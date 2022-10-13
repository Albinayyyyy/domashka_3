//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7-5, 0); B (1,-1,9) -> 11.53

double Dist (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result;
    result= Math.Sqrt((x2 - x1)*(y2 - y1)*(z1 - z2));
    //resul = Math.Rount(resolt, 2);
    return result;
}

Console.Clear();
Console.Write("Введите Х координаты точки А: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координаты точки А: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Х координаты точки B: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координаты точки B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Х координаты точки C: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z координаты точки C: ");
int z2 = int.Parse(Console.ReadLine()!);


Console.Write($"Длина отрезка АВ: (Dist(x1,y1,x2,y2,z2):f3 ");
