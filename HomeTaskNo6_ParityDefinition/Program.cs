
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Дано число ");
        int number = new Random().Next(1, 100);
        Console.WriteLine(number);
        // Генерируем случайное число от 1 до 100 и выводим его на экран
        if (number % 2 == 0)
        {
            Console.WriteLine($"Число {number} чётное");
        }
        else
        {
            Console.WriteLine($"Число {number} нечётное");
        }
        // Проверяем чётность/нечётность и выводим результат на экран
    }
}