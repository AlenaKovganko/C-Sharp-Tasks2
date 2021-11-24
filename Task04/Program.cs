// Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.
int [,] a = new int [3,4];
void Array(int [,] a)
{
    for(int i =0; i <a.GetLength(0); i++)
    {
        for(int j = 0; j<a.GetLength(1); j++)
        {
            a [i,j]  = new Random().Next(-45,45);
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
void Count(int [,] a, out int count)
{
    count = 0;
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j = 0;j<a.GetLength(1); j++)
        {
            if(a[i,j]>-9 & a[i,j]<0) count = count + 1; 
        }
    }
    
}

Array(a);
PrintArray(a);
int c;
Count(a, out c);
Console.WriteLine($"Количество отрицательных элементов, больше -9. = {c}");

