// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

int[,] CreateArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}
void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
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

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        for (int k = j+1; k < col; k++)
        {
            if (myArray[i, k] > myArray[i, j])
            { 
            int temp = myArray[i,j];
            myArray[i, j] = myArray[i, k];
            myArray[i, k] = temp;
            }
        }
        Console.Write($"{myArray[i, j]} ");
    }
    Console.WriteLine();
}
