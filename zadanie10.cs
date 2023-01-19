Console.WriteLine("Введите трёхзначное число");
int x = Convert.ToInt32(Console.ReadLine());



while (x >= 100)
{
    x = x / 10;   
}


int y = x % 10; 

Console.WriteLine(y);
