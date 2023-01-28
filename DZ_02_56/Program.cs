/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(rows, columns, 0, 10);
PrintArray(array);
RowMinSum(array);

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

void RowMinSum(int[,] inArray)
{
    int[] sum = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum[i] = sum [i] + inArray[i,j];
        }
        Console.WriteLine($"Сумма строки {i+1} равно {sum[i]}");
     }
    int min = sum [0];
    int k = 0;
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        if (min > sum[i]) 
        {
            min = sum[i];
            k = i;
        }
    } 
    Console.WriteLine($"Строка с наименьшей суммой элементов: {k+1} строка");
}
