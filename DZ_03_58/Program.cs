/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Введите количество строк первого массива: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = CreateArray(rows1, columns1, 0, 10);
PrintArray(array1);
Console.WriteLine("");

Console.Write("Введите количество строк второго массива: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = CreateArray(rows2, columns2, 0, 10);
PrintArray(array2);
Console.WriteLine("");

MultiplicationArray(array1, array2);

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

void MultiplicationArray(int[,] inArray1, int[,] inArray2)
{
    int[,] MultiArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    if (inArray1.GetLength(1) != inArray2.GetLength(0))
    {
        Console.Write("Произведение двух двухмерных массивов не возможно");
    }
    else
    {
        for (int i = 0; i < inArray1.GetLength(0); i++)
        {
            for (int k = 0; k < inArray2.GetLength(1); k++)
            {
                int sum = 0;
                Console.Write($"Расчет числа массива ({i},{k}): ");
                for (int j = 0; j < inArray2.GetLength(0); j++)
                {
                    sum = sum + inArray1[i, j] * inArray2[j, k];
                    Console.Write($"{inArray1[i, j]}*{inArray2[j, k]} = {inArray1[i, j] * inArray2[j, k]}     ");
                }
                MultiArray[i, k] = sum;
                Console.WriteLine();
            }
        }
    Console.WriteLine("Произведение двух двухмерных массивов равно:");
    PrintArray(MultiArray);
    }
}
