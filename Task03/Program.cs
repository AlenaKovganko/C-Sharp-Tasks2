// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение элементов, кратных 3 и 5.
int [,] a = new int [6,10];
void Array(int [,] a)
{
    for(int i =0; i <a.GetLength(0); i++)
    {
        for(int j = 0; j<a.GetLength(1); j++)
        {
            a [i,j]  = new Random().Next(1,45);
        }
    }
}
void PrintArray(int [,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j = 0;j<a.GetLength(1); j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}
void Multiplicity(int [,] a, out int sum, out int multi)
{
    sum = 0;
    multi = 1;
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j = 0;j<a.GetLength(1); j++)
        {
            if(a[i,j]%3==0 & a[i,j]%5==0) sum = sum + a[i,j]; 
            if(a[i,j]%3==0 & a[i,j]%5==0) multi = multi *a[i,j];

        }
    }
    
}



Array(a);
PrintArray(a);
int s,m;
Multiplicity(a, out s,out m);
Console.WriteLine($" Сумма чисел кратных 3 и 5 = {s}");
Console.WriteLine($" Произведение чисел кратных 3 и 5  = {m}");

