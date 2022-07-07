

int [,] matrix = new int [4,4];
int num = 1;
int row=0;
int col=0;
void FillImage (int row, int col)
{
    matrix[row,col] = num;
    num++;
}
void FillImgRight (int row, int col)
{
    matrix[row,col+1] = num;
    num++;
}
void FillImgDown (int row, int col)
{
    matrix[row+1,col] = num;
    num++;
}

void FillImgLeft (int row, int col)
{
    matrix[row,col-1] = num;
    num++;
}

void FillImgUp (int row, int col)
{
    matrix[row-1,col] = num;
    num++;
}

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
int step = matrix.GetLength(0)*matrix.GetLength(1);
FillImage(row,col);

while (col<3 && matrix[row,col+1]==0)
{
    FillImgRight(row,col);
    col++;
}

// FillImgRight(row,col);
// col++;
// FillImgRight(row,col);
// col++;
// FillImgRight(row,col);
// col++;
// FillImgDown(row,col);
// row++;
// FillImgDown(row,col);
// row++;
// FillImgDown(row,col);
// row++;
// FillImgLeft(row,col);
// col--;
// FillImgLeft(row,col);
// col--;
// FillImgLeft(row,col);
// col--;
// FillImgUp(row,col);
// row--;
// FillImgUp(row,col);
// row--;
// FillImgRight(row,col);
// col++;
// FillImgRight(row,col);
// col++;
// FillImgDown(row,col);
// row++;
// FillImgLeft(row,col);

PrintArray(matrix);
