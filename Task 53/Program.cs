// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [,] matrix = new int[4,5];

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

void ReversIndex (int [,] matr)
{
    int i =0;
    int j = 0;
    int temp = 0;
    temp = matr[i,j];
    matr[i,j] = matr[matr.GetLength(0)-1,matr.GetLength(1)-1];
    matr[matr.GetLength(0)-1,matr.GetLength(1)-1] = temp;
}

ReversIndex(matrix);
Console.WriteLine();
PrintArray(matrix);

