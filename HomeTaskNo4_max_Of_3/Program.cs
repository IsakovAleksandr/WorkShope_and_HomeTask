﻿internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Дано 3 числа:"); // Вывели сообщение "Дано 3 числа"
        int number1 = new Random().Next(1, 100);
        int number2 = new Random().Next(1, 100);
        int number3 = new Random().Next(1, 100);
        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);
        // Свормировали 3 случайных числа методом Random и вывели 
        //их на экран
        int max = number1;
        if(number2 > max)
        {
            max = number2;
        }
        if(number3 > max)
        {
            max = number3;
        }
        Console.WriteLine($"Максимальное число = {max}");
        //Осуществили проверку на максимум используя оператор 
        //if и вывели максимум на экеран
    }
}