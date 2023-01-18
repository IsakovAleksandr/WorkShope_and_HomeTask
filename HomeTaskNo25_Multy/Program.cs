// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Input a number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input a rate");
int b = int.Parse(Console.ReadLine());

int Pow(int num, int rate)
{
    if (rate == 0) return 1;
    int res = num;

    for (int i = 2; i <= rate; i++)
    {
        res *= num;
    }
    return res;
}

Console.WriteLine($"number {a} in rate {b} = {Pow(a, b)}");