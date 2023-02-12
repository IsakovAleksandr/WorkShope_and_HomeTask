//Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] GetMultyplMatrix(int[,] array1, int[,] array2)
{
int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
for (int row = 0; row < array1.GetLength(0); row++)
{
    for (int col = 0; col < array2.GetLength(1); col++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            array3[row, col] += array1[row, k] * array2[k, col];
        }
    }
}
return array3;
}
Console.WriteLine("Input rows number for array1");
int row1 = int.Parse(Console.ReadLine());
Console.WriteLine("Intput columns number for array1");
int col1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input rows number for array2");
int row2 = int.Parse(Console.ReadLine());
Console.WriteLine("Intput columns number for array2");
int col2 = int.Parse(Console.ReadLine());
if (col1 != row2)
{
    System.Console.WriteLine("Such matrixes aren't able to be multyplicated!");
    return;
}

int[,] myArray1 = CreateArray(row1, col1, 1, 10);
int[,] myArray2 = CreateArray(row2, col2, 1, 10);
PrintArray(myArray1);
System.Console.WriteLine();
PrintArray(myArray2);
System.Console.WriteLine();
PrintArray(GetMultyplMatrix(myArray1,myArray2));