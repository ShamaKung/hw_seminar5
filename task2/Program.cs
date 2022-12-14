Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int sumI = 0;

int[] array = new int[n];

for(int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-99, 100);
}

for(int i = 0; i < n; i++)
{
    if(i % 2 == 1)
    {
        sumI = sumI + array[i];
    }
}

for(int i = 0; i < n; i++)
{
    Console.Write("{0,5}", array[i]);
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях " + sumI.ToString());