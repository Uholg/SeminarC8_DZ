/*Задача 60. .Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int rows = ReadInt("Введите количество строк:");
int columns = ReadInt("Введите количество столбцов:");
int line = ReadInt("Введите количество рядов:");
int[,,] numbers = new int [rows, columns, line];
int[] arr = new int[90];

FillRandomNumbers(arr,10,99);

int n=0;
if (arr.Length>=rows*columns*line)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
            numbers[i,j,k] = arr[n];
            n++;
            }
        }
    }
    Write3DArray(numbers);
}
else {Console.WriteLine("Элементов трехмерного массива больше чем количество уникальных двузначных чисел. ");}



void FillRandomNumbers(int[] array, int min, int max)
{
            Random r = new Random();
            int tmp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min, max + 1);
                tmp = array[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (array[i] == array[j])
                        {
                            array[i] = r.Next(min, max + 1);
                            j = 0;
                            tmp = array[i];
                        }
 
                        tmp = array[i];
                    }
                }
            }
        }


void Write3DArray(int[,,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {    Console.Write("|");
         for (int k = 0; k < array.GetLength(2); k++)
    {
    Console.Write($"{array[i,j,k],1} ({i},{j},{k})|");
    }
    Console.WriteLine();
    }
}
}


int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

