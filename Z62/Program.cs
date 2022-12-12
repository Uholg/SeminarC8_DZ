/*Задача 62. Напишите программу, которая заполнит спирально массив 
4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int r = ReadInt("Введите количество строк и столбцов: ");
int[,] numbers = new int [r, r];
var arr = new int [r];
numbers=Spirale(r);
Write2DArray(numbers);

    int[,] Spirale(int n)
        {
            var result = new int[n, n];
              for (int i = 0; i < n; i++)
              {   
            for (int j = 0; j < n; j++)
                {
                int ik = i + 1;     
                int jk = j + 1;    
            	int t =  (jk - ik+ n) / n;
                int Ic = Math.Abs(ik - n / 2  - 1) + (ik - 1)/(n /2) * ((n-1) % 2);
                int Jc = Math.Abs(jk - n / 2  - 1) + (jk - 1)/(n /2) * ((n-1) % 2);
                int Ring = n / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
                int s = ik - Ring + jk - Ring - 1;    
                int m =  4 * Ring * (n - Ring);
result[i,j] =  m + t * s + Math.Abs(t- 1) * (4 * (n - 2 * Ring) - 2 - s);
                }   
            }  
            return result;
        }

void Write2DArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    Console.Write(String.Format("{0,3}",array[i,j]));
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
