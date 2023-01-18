// Задача 23: Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Input a number ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Cubs of numbers from 1 till {N}:");
for (int i = 1; i <= N; i++)
{
    int result = (int)Math.Pow(i, 3);

    Console.WriteLine(result);
}
