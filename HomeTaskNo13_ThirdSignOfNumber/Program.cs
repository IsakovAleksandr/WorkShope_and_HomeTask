Console.WriteLine("Введите трёхзначное или двухзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 >= 1 && number / 100 < 10)
{
    int num = number % 100 % 10;
    Console.WriteLine($"Третий символ числа {number} - {num}");
}
else if (number / 10 >= 1 && number / 10 < 10)
{
    Console.WriteLine($"Третий символ числа {number} отсутствует");
}
else if (number / 10 < 1 || number / 10 >= 100)
{
    Console.WriteLine("Ошибка! Введите трёхзначное или двузначное число ");
}