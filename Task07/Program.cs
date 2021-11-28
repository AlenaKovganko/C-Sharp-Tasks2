// Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их квадраты.
int [,] a = new int [2,3]; //Создание и печать массва a
void CreateArray(int [,] a)
{
    for(int i =0; i < a.GetLength(0); i++ )
    {
        for(int j =0; j < a.GetLength(1); j++ )
        {
            a [i,j] = new Random() .Next(1,100);
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}

void ChangeElement(int [,] a)
{
    for(int i =0; i < a.GetLength(0); i++ )
    {
        for(int j =0; j < a.GetLength(1); j++ )
        {
            a [i,j] = a [i,j]* a [i,j];
            Console.Write($"{a[i,j],6}");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Исходный рандомный массив a");
CreateArray(a);
Console.WriteLine("Массив a после замены всех элементов на их квадраты");
ChangeElement(a);




    



