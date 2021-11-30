// Дан целочисленный двумерный массив, размерности n х m. Найти максимум и минимум. Поменять их местами.
int [,] a = new int [3,4];
int row1, column1;
int row2, column2;
int Max;
int Min;
void Array(int [,] a)
{
    for(int i =0; i <a.GetLength(0); i++)
    {
        for(int j = 0; j<a.GetLength(1); j++)
        {
            a [i,j]  = new Random().Next(1,100);
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

void FindMaxNumber(int [,] a, out int Max, out int row1, out int column1)
{
    Max = a[0,0];
    row1 = 0;
    column1 =0;
    for(int i = 0; i<a.GetLength(0); i++)
    {
        for(int j = 0; j<a.GetLength(1); j++)
        {
            if (a[i,j] > Max) 
            {
                Max = a[i,j];
                row1 = i;
                column1 =j;
            }
        }
    }  
}
void FindMinNumber(int [,] a, out int Min, out int row2, out int column2)
{
    Min = a[0,0];
    row2 = 0;
    column2 =0;
    for(int i = 0; i<a.GetLength(0); i++)
    {
        for(int j = 0; j<a.GetLength(1); j++)
        {
            if (a[i,j] < Min) 
            {
                Min = a[i,j];
                row2 = i;
                column2 =j;
            }
        }
        
    }
}
void ChangeArray(int [,] a)
{
for(int i = 0; i<a.GetLength(0); i++)
    {
        for(int j = 0; j<a.GetLength(1); j++)
        {
            if (a[i,j] == Max) a [i,j] = Min; 
            else if (a[i,j]== Min) a[i,j] = Max;
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    } 
}
Array(a);
Console.WriteLine("Рандомный массив a");
PrintArray(a);
FindMaxNumber(a,out Max, out row1, out column1);
FindMinNumber(a,out Min, out row2, out column2);
Console.WriteLine($"Максимальное число {Max} строка {row1} колонка {column1}");
Console.WriteLine($"Минимальное число {Min} строка {row2} колонка {column2}");
Console.WriteLine("Рандомный массив a после обмена Max и Min местами");
ChangeArray(a);





