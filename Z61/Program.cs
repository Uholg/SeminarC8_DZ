/*Задача 61: Вывести первые N строк треугольника Паскаля.
 Сделать вывод в виде равнобедренного треугольника*/

int n = ReadInt("Введите количество строк треугольника Паскаля:");
int[,] triangle= new int[n,n+(n-1)];

if (n==1)
Console.WriteLine(n);
else 
{triangle[0,triangle.GetLength(1)/2]=1;
    for (int i = 1; i < triangle.GetLength(0); i++)
        {for (int j = 1; j < triangle.GetLength(1)-1; j++)
            {
            triangle[i,j]=triangle[i-1,j-1]+triangle[i-1,j+1];
            }  
        }
triangle[triangle.GetLength(0)-1,0]=1;
triangle[triangle.GetLength(0)-1,triangle.GetLength(1)-1]=1;  
}

Write2DArray(triangle);

void Write2DArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{ 
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j]==0)
        {Console.Write(String.Format("{0,3}"," "));}
        else 
        {
        Console.Write(String.Format("{0,3}",array[i,j]));
         }
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