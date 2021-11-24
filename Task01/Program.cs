
int [,] a; //ссылочный тип (references)
//int i значимый (value)
//  Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива.
a = new int [2,3]; 
void SetArray2 (int [,] a)
{
for(int i=0; i <a.GetLength(0); i++)
{
    for (int j=0; j<a.GetLength(1);j++)
    {
        a[i,j] = new Random().Next(1,10);
    }

}
}

void Print (int [,] a)
{
for(int i=0; i <a.GetLength(0); i++)
{
    for (int j=0; j<a.GetLength(1);j++)
    {
        Console.Write($"{a[i,j],4}");
    }
    Console.WriteLine();

}
}

SetArray2(a);
Print (a);

void Task01(int [,] a, out int sum, out int multi)
{
    sum = 0;
    multi=1;
    for(int i=0; i <a.GetLength(0); i++)
{
    for (int j=0; j<a.GetLength(1);j++)
    {
        sum = sum + a [i,j];
        multi = multi*a[i,j];
    }

}

}

int s,m;
Task01(a,out s, out m);
Console.WriteLine($"Сумма всех элементов массива: {s}");
Console.WriteLine($"Произведение всех эементов массива: {m}");



