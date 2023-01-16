// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1,x2,x3;
int y1,y2,y3;

Console.WriteLine("Please, input A coordinates: ");
x1 = int.Parse(Console.ReadLine());
x2 = int.Parse(Console.ReadLine());
x3 = int.Parse(Console.ReadLine());

Console.WriteLine("Please, input B coordinates: ");
y1 = int.Parse(Console.ReadLine());
y2 = int.Parse(Console.ReadLine());
y3 = int.Parse(Console.ReadLine());

double distance = (double)Math.Pow((Math.Pow((y1 - x1), 2)) + 
(Math.Pow((y2 - x2), 2))+
(Math.Pow((y3 - x3), 2)), 0.5);

Console.WriteLine($"Distance between A and B = {distance}");
