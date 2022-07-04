// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] matrix = new int[3,4];

void FillArray(int [,] matr) // заполнение матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,15);
            
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


void SortMatrix(int [,] matr)
{
 int temp = 0;
 int i = 0;
 
     while (i < matr.GetLength(0))
    {
        int step = 0;
        for (int j = 0; j < matr.GetLength(1)-1; j++) 
        {
            while (step<matr.GetLength(1))
            {
                if (matr[i,j]<matr[i,j+1] )
                {
                    temp = matr[i,j];
                    matr[i,j] = matr[i,j+1];
                    matr[i,j+1] = temp;
                    
                }
                step++;
            }
            
        }
        i++;
    }
    PrintArray(matr);
}

Console.WriteLine();
SortMatrix(matrix);

Console.WriteLine();



