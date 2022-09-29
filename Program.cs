Console.Clear();

Console.Write("Введите число, которое нужно возвести в степень: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число, на какую степень нужно возвести: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{Power(num1, num2)}");

int Power(int x, int y)
{
    int sqr_num = 1;
    for (int i = 0; i < y; i++)
    {
        sqr_num = sqr_num * x;
    }
    return(sqr_num);
}