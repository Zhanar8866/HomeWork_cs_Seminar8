/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного 
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(rows, columns, 0, 100);
PrintArray(array);
Console.WriteLine();
Descending(array);

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Descending(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1) / 2; k++)
        {
            for (int j = 1 + k; j < inArray.GetLength(1) - k; j++)
            {
                if (inArray[i, j - 1] > inArray[i, j])
                {
                    int temp = inArray[i, j - 1];
                    inArray[i, j - 1] = inArray[i, j];
                    inArray[i, j] = temp;
                }

            }
            for (int j = inArray.GetLength(1) - k -1; j > k; j--)
            {
                if (inArray[i, j] < inArray[i, j - 1])
                {
                    int temp = inArray[i, j - 1];
                    inArray[i, j - 1] = inArray[i, j];
                    inArray[i, j] = temp;
                }

            }
        }
    }
    PrintArray(inArray);
}
