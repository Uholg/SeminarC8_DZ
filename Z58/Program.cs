/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int rows1 = ReadInt("Введите количество строк первой матрицы: ");
int columns1 = ReadInt("Введите количество столбцов первой матрицы: ");
int rows2 = ReadInt("Введите количество строк второй матрицы: ");
int columns2 = ReadInt("Введите количество столбцов второй матрицы: ");
int[,] matrix1 = new int [rows1, columns1];
int[,] matrix2 = new int [rows2, columns2];
int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
 
Fill2DArrayRandomNumbers(matrix1);
Write2DArray(matrix1);
Fill2DArrayRandomNumbers(matrix2);
Write2DArray(matrix2);


   if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    else {Console.WriteLine("Умножение невозможно");}

Write2DArray(resultMatrix);

void Fill2DArrayRandomNumbers(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = new Random().Next(1,10);
    }
}
}

void Write2DArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


