// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(8, 1, 30);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


int[] GetRandomArray(int size, int start, int end)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(start, end);
    }

    return result;
}
int summ = 0;
for (int i = 1; i < array.Length; i+=2)
{
    summ += array[i];
}
Console.WriteLine(summ);