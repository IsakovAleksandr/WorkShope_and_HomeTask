Console.WriteLine("Введите число от 1 до 7:");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        Console.WriteLine("Понедельник - рабочий день");
        break;
    case 2:
        Console.WriteLine("Вторник - рабочий день");
        break;
    case 3:
        Console.WriteLine("Среда - рабочий день");
        break;
    case 4:
        Console.WriteLine("Четверг - рабочий день");
        break;
    case 5:
        Console.WriteLine("Пятница - рабочий день");
        break;
    case 6:
        Console.WriteLine("Суббота - выходной!");
        break;
    case 7:
        Console.WriteLine("Воскресение - выходной!");
        break;
}
Console.ReadKey();