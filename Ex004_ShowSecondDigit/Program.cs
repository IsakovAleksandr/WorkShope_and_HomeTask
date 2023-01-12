int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное число {number}");

ShowSecondDigit(number);
ShowSecondDigit(number.ToString());