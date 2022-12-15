Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

double sumI = 0;

double[] array = new double[n];

for(int i = 0; i < n; i++)
{
    array[i] = new Random().NextDouble() * 100;
}

for(int i = 0; i < n; i++)
{
    Console.Write("{0,6:F2}", array[i]);
}

Console.WriteLine("");

double maxValue = array.Max();

double minValue = array.Min();

Console.WriteLine("макс " + Math.Round(maxValue, 2));
Console.WriteLine("мин " + Math.Round(minValue, 2));

double dev = maxValue - minValue;

Console.WriteLine("Разница " + Math.Round(dev));