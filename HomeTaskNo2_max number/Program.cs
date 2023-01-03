internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите первое число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} больше {number2}");
        }
        else
        {
            Console.WriteLine($"{number2} больше {number1}");
        }
    }
}