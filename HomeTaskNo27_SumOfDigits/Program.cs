// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Please input an a number");
int a = int.Parse(Console.ReadLine());

int SumOfNum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.WriteLine($"Summ of digits in number a = {SumOfNum(a)}");