//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int xa = ReadInt("Введите координату X первой точки: ");
int ya = ReadInt("Введите координату Y первой точки: ");
int za = ReadInt("Введите координату Z первой точки: ");
int xb = ReadInt("Введите координату X второй точки: ");
int yb = ReadInt("Введите координату Y второй точки: ");
int zb = ReadInt("Введите координату Z второй точки: ");

int A = xb - xa;
int B = yb - ya;
int C = za - zb;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}