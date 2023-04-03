//Задача 21
// Напишите программу, которая принимает на 
//вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты для первой точки");
Console.Write("X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для второй точки");
Console.Write("X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());

double findingDist = FindDistance(X1,X2,Y1,Y2,Z1,Z2);
Console.WriteLine($"Расстояние между точками равно -> {Math.Round(findingDist,2,MidpointRounding.ToZero)}");

double FindDistance(int x1Coor,int x2Coor, int y2Coor,int y1Coor,int z1Coor,int z2Coor)
{
    int catet1 = x2Coor - x1Coor;
    int catet2 = y2Coor - y1Coor;
    int catet3 = z2Coor - z1Coor;
    double distance = Math.Sqrt(catet1*catet1+catet2*catet2+catet3*catet3);
    return distance;
}

