// Напишите программу, которая на вход принимает число 
// и выводит его квадрат (число умноженное на себя)
// Например
// 4 - 16
// 3 - 9

internal class Program
{
    private static void Main(string[] args)
    {
Console.WriteLine("введите число");
string stringNumber = Console.ReadLine();
int number;
while(!int.TryParse(stringNumber, out number))
{
    Console.WriteLine("Ошибка! Введите одно целое число");
stringNumber = Console.ReadLine().Trim();
}
//         Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine($"квадрат числа {number}  равен {result}");
//Console.WriteLine("квадрат числа " + number + " равен " + result);
    }
}