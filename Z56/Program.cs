/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
 и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int [rows, columns];


Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);

int sum = 0;
int[] sumRow=new int[rows];


for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++) 
    {    
            sum+= numbers[i,j];      
    }
    sumRow[i]=sum;
    sum=0;
}


int indexRowMinSum = 0;
if (sumRow.Length != 1)
{
int minSum = sumRow[0];
    for (int i = 1; i < sumRow.Length; i++)
    {
        if (sumRow[i] < minSum)
        {
            minSum = sumRow[i];
            indexRowMinSum = i;
        }
        else if (sumRow[i]==minSum)
        {   
            int indexRowMinSum1 = i;   
            Console.WriteLine((indexRowMinSum1 + 1) + " строка");}   
    }
    Console.WriteLine((indexRowMinSum + 1) + " строка");
}


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

