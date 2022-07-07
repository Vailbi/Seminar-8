// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows,colums];



void FillArray(int [,] matr) // 
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
            
        }
    }
}

FillArray(matrix);

void PrintArray(int [,] matr) // печать матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);
Console.WriteLine();

InvertMatrix(matrix);

void InvertMatrix (int [,] matr)
{
    int [,] NewMatr = new int[matr.GetLength(0),matr.GetLength(1)];
    if (matr.GetLength(0)==matr.GetLength(1))
    {
        
    
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                NewMatr[i,j] = matr[j,i];
            }
        }
        PrintArray(NewMatr);
    }
    else
    {
        Console.WriteLine("Невозможно изменить матрицу! Количество строк не ровно количеству столбцов");
    }
}
