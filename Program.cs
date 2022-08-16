//Задача с поворотом матрицы


void FillArray(int[,] matrix1)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix1)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}


void TurnArray(int[,] matrix2, int[,] matrix3)
{
for (int i = 0; i <= 4; ++i)
{
    for (int j = 0, t = 4; j <= 4; ++j, --t)
    {
        matrix2[i, j] = matrix3[t, i];
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
}


int[,] matrix = new int[5, 5];
int[,] matrix1 = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

TurnArray(matrix1, matrix);