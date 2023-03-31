int Read()
{
    System.Console.WriteLine("Введите пятизначное число:");
    int x = int.Parse(Console.ReadLine());
    if (x < 9999 || x > 99999) throw new ArgumentOutOfRangeException("x");
    return x;
}

int x = Read();

int Polindrom(int number)
{
    int x = 0;
    int x1 = number / 10000;
    number = number - x1*10000;
    int x2 = number / 1000;
    number = number - x2*1000;
    int x3 = number / 100;
    number = number - x3*100;
    int x4 = number / 10;
    number = number - x4*10;
    int x5 = number;
    if (x1==x5 && x2==x4) x = 1;
    else x = 0;
    return x;
}

int y = Polindrom(x);
if ( y == 1) System.Console.WriteLine($"Ваше число {x} является палиндромом.");
else System.Console.WriteLine($"Ваше число {x} не является палиндромом.");