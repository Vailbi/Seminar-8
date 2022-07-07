// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int [,] matrix = new int[4,4];

void FillArray(int [,] matr) // заполнение матрицы случайными числами
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

int[] newMatr = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < newMatr.Length; k++)
        {
            if (k==matrix[i,j])
            {
                newMatr[k]++;
            }
        }
    }
}

for (int i = 0; i < newMatr.Length; i++)
{
    if (newMatr[i]!=0)
    {
        if (newMatr[i]==1)
        {
            Console.WriteLine($"{i} встречается {newMatr[i]} раз");
        }
        else
        {
            Console.WriteLine($"{i} встречается {newMatr[i]} раз");
        }
    }
}
Console.WriteLine();
for (int i = 0; i < newMatr.Length; i++)
{
    Console.Write (newMatr[i] + " ");
}

//int count=0;

// int SearchNumberInMatrix(int [,] matr, int number)
// {
    
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (number==matr[i,j])
//             {
//                 count++;
//             }
//         }
//     }
//     return count;
// }

// void SearchCountInMatrix(int [,] matr)
// {
//     int i=0;
//     int j=0;
//     int result = matr[i,j];
//     for (i = 0; i < matr.GetLength(0); i++)
//     {
//         for (j = 0; j < matr.GetLength(1); j++)
//         {
//             SearchNumberInMatrix(matr, matr[i,j]);
//             Console.WriteLine($"{matr[i,j]} встречается {count} раз");
//             count = 0;
//         }
//     } 
// }
// System.Console.WriteLine();
// SearchCountInMatrix(matrix);
