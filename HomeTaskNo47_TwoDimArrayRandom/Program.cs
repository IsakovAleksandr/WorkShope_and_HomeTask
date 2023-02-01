// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateAray(int row, int col, double minValue, double maxValue)
{
    double[,] dArray = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            dArray[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
            // dArray[i, j] = Math.Round(new Random().NextDouble() * 15 - 10, 1);
        }
    }
    return dArray;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;
double[,] array = CreateAray(m, n, -5, 5);
PrintArray(array);