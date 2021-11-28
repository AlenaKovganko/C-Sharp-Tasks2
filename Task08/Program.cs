// Дан целочисленный двумерный массив, размерности n х m. Найти среднее арифметическое всех элементов массива.
double [,] a = new double [2,3];
void CreateArray(double [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            a [i,j] = new Random().Next(1,10);
            Console.Write($"{a[i,j], 4}");
        }
        Console.WriteLine();
    }
}

double Aver(double [,] a)
{
    double sum = 0;
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            sum = sum + a[i,j];
        }
    }
    return sum/a.Length;
}

Console.WriteLine("Рандомный массив a");
CreateArray(a);
Console.WriteLine($"Среднеарифметическое массива а {Aver(a)}");

