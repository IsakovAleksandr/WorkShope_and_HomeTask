// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateAray(int row, int col, int minValue, int maxValue)
{
    int[,] ranArray = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            ranArray[i, j] = new Random().Next(minValue, maxValue);
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

void showValue(int[,] collection, int str, int col)
{
    
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            if (str >= collection.GetLength(0) || col >= collection.GetLength(1))
            {

                Console.Write($"Error! Please input index of string < {collection.GetLength(0)} and index column < {collection.GetLength(1)}");
                
            }
            
            else if (i == str && j == col) Console.WriteLine($"Value you've requested is {collection[i, j]}");
        
        }
        
    }
    
}

Console.WriteLine("Input rows number");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Intput columns number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input minimum value ");
int startValue = int.Parse(Console.ReadLine());
Console.WriteLine("Intput maximum value");
int endValue = int.Parse(Console.ReadLine());
int[,] myArray = CreateAray(m, n, startValue, endValue);
Console.WriteLine();

PrintArray(myArray);
// Console.WriteLine("Input the address of element");
// int address = int.Parse(Console.ReadLine());
Console.WriteLine("Input the index of string");
int addStr = int.Parse(Console.ReadLine());
Console.WriteLine("Input the index of column");
int addCol = int.Parse(Console.ReadLine());
// int val = 
showValue(myArray, addStr, addCol);
// Console.WriteLine($"Requested element value is: {val}");