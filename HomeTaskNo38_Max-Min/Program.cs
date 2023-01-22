// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = { 34.55, 23.78, 36.21, 58.31, 89.23 };
// Console.WriteLine(array);

//void FillArray(double[] collection)

// {
//     int length = collection.Length;
//     int index = 0;
//     Random rand = new Random();
//     while (index < length)
//     {
//         //array[i] = rand.Next(-5.0, 5.0) + rand.NextDouble();
//         collection[index] = rand.Next() + rand.NextDouble();
//         index++;
//     }
// }
void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// double[] array = new double[8];

//FillArray(array);
PrintArray(array);
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine($"Diffenence between max and min = {max - min}");