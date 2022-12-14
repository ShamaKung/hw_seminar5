Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int count = 0;

int[] array = new int[n];

for(int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);
}

for(int i = 0; i < n; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}

for(int i = 0; i < n; i++)
{
    Console.Write("{0,5}", array[i]);
}
Console.WriteLine("четных элементов " + count.ToString());