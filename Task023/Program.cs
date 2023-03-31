int Read()
{
    System.Console.WriteLine("Введите число:");
    int x = int.Parse(Console.ReadLine());
    if (x < 0) throw new ArgumentOutOfRangeException("x");
    return x;
}

int x = Read();

void Magic(int x)
{
    int a = 1;
    int b = 0;
    while (a <= x)
    {
        b = (int)Math.Pow(a, 3);
        a++;
        System.Console.Write(b + " ");
    }
    
}

Magic(x);