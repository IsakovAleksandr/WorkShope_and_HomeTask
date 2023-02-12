// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int strNum, int colNum, int minVal, int maxValue)
{
 int[,] ranArray = new int[strNum, colNum];
    for (int i = 0; i < strNum; i++)
    {
        for (int j = 0; j < colNum; j++)
        {
            ranArray[i, j] = new Random().Next(minVal, maxValue);
        }
    }
    return ranArray;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ColumnAvg (int[,] Array)
{

    // int sum = 0;
    for  (int i = 0; i < Array.GetLength(1); i++)
    {
     int sum = 0;
     int avg;
        for  (int j = 0; j < Array.GetLength(0); j++)
        {
            sum += Array[j, i];
        }
        avg = sum / Array.GetLength(0);
        Console.Write($"{avg}; ");
    }
    //return avg;
}
Console.WriteLine("Input rows number"); int row = int.Parse(Console.ReadLine());
Console.WriteLine("Intput columns number"); int col = int.Parse(Console.ReadLine());
Console.WriteLine("Input minimum value ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Intput maximum value");
int max = int.Parse(Console.ReadLine()); int[,] myArray = CreateArray(row, col, min, max);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine();
ColumnAvg(myArray);


