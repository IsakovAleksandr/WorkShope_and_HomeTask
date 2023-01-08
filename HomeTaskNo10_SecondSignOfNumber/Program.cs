Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 >= 1 && number / 100 < 10)
{
    int num = number / 10 % 10;
    // int sign = num % 10;
    // Console.WriteLine($"Второй символ числа {number} - {sign}");
    Console.WriteLine($"Второй символ числа {number} - {num}");
}
else
{
    Console.WriteLine("Ошибка! Введите трёхзначное число ");
}