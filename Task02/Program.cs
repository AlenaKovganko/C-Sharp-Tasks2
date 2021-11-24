// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.
int [,] a = new int [2,3];
void Array(int [,] a)
{
    for(int i =0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1);j++)
        {
            a[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int [,] a)
{
    for(int i=0; i < a.GetLength(0); i++)
    {
        for(int j=0; j <a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}
void EvenSumMulti(int [,] a, out int sum, out int multi)
{
    sum = 0;
    multi = 1;
    for(int i =0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1);j++)
        {
            if(a[i,j]%2==0) sum = sum + a [i,j]; 
            if(a[i,j]%2==0) multi = multi* a[i,j]; 
        }

    }

}
Array(a);
Console.WriteLine("Рандомный массив");
PrintArray(a);
int m,s;
EvenSumMulti(a, out s, out m);
Console.WriteLine($"Сумма всех четных элементов {s}");
Console.WriteLine($"Произведение всех четных элементов {m}");
