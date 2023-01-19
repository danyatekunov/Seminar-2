Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdDigit(x));
int ThirdDigit(int x)
{
int y = -1;

if (x >= 100)

    while (x > 999)
    {
        x = x / 10;
    }
    y = x % 10;

return y;
}
