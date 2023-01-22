// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = CreateRandomArray(8, 100, 999);

Console.WriteLine($"[{String.Join(" / ", array)}]");


int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int GetEven()
{
    int i = 0;
    int qty = 0;
    while (i < array.Length)
    {

        if (array[i] % 2 == 0)
        {
            qty += 1;

        }
        i++;

    }
    return qty;
}
Console.WriteLine(GetEven(array));