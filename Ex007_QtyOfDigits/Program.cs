

int Length(int number)
{
 int count = 1;
    while(number / 10 != 0)
    {
        number = number / 10;
        count += 1;
    }
    return count;

}
Console.WriteLine("input a number of any digits");
int a = int.Parse(Console.ReadLine());
int result = Length(a);
Console.WriteLine($"qty of number digits = {result}");