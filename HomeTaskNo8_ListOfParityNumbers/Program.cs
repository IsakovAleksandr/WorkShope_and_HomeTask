Console.Clear();
Console.Write("Дано число ");
int N = new Random().Next(10, 30);
Console.WriteLine(N); 
// Сгенерировали случайное число от 10 до 30
Console.WriteLine($"Вот список чётных чисел от 1 до {N}:");
for (int num = 1; num <= N; num++)
{
    if (num % 2 == 0) // Вставили условие проверки на чётность в цикл
    {
        Console.WriteLine(num);
    }
// Вывели на экран список чётных чисел от 1 до N
}
