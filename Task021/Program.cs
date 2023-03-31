double Read(string coordinate)
{
    System.Console.WriteLine($"Введите {coordinate}:");
    double input = double.Parse(Console.ReadLine());
    return input;
}

double x1 = Read("x1");
double y1 = Read("y1");
double z1 = Read("z1");

double x2 = Read("x2");
double y2 = Read("y2");
double z2 = Read("z2");

double Magic (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double Length = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) +Math.Pow(z2-z1, 2));
    return Length;
}

double Length = Math.Round(Magic (x1,y1,z1,x2,y2,z2), 2);
System.Console.WriteLine($"Расстояние между точкой 1 с координатами ({x1}, {y1}, {z1}) и точкой 2 с координатами ({x2}, {y2}, {z2}) равно {Length}");