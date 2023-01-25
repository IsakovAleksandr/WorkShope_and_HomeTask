// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Input numbers separate by Space");
int [] num = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Count of numbers higher then 0 -> {GetCountPosNum(num)}");
Console.WriteLine();

int [] GetArrayFromString(string stringArray)
{
    string [] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int [] result = new int[numS.Length];
    for (int i = 0; i < numS.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPosNum(int [] array)
{
    int count = 0;
    // for (int i = 0; i < array.Length; i++)
    // {
    //     if (array[i] > 0) count++;
    // }
    foreach (int item in array)
    {
        if(item>0) count++;
    }
    return count;
}