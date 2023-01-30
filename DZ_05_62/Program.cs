/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
*/

int[,] array = CreatSpiral(4, 4);
PrintArray(array);


int[,] CreatSpiral(int m, int n)
{
    int[,] result = new int[m, n];
    int sum = 0;
    
    for (int i = 0; i < m; i++)
    {
        for (int j = i; j < n - i; j++) // вправо
        {
            if (j != n - i - 1)
            {
                sum = sum + 1;
                result[i, j] = sum;
                //Console.WriteLine($"[{i},{j}] = {result[i, j]}");
            }
            else
                {
                    for (int k = i ; k < m - i; k++) // вниз
                    {
                        if (k != m - i - 1)
                        {
                        sum = sum + 1;
                        result[k, j] = sum;
                        //Console.WriteLine($"[{k},{j}] = {result[k, j]}");
                        }
                        else
                        {
                            for (int l = n - i - 1; l > i-1; l--) // влево
                            {
                                if (l != i)
                                {
                                    sum = sum + 1;
                                    result[k, l] = sum;
                                    //Console.WriteLine($"[{k},{l}] = {result[k, l]}");
                                }
                                else
                                {
                                    for (int p = m - i - 1; p > i; p--)  //вверх
                                    {
                                        sum = sum + 1;
                                        result[p, l] = sum;
                                        //Console.WriteLine($"[{p},{l}] = {result[p, l]}");
                                    }

                                }
                            }
                        }

                    }
                }
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
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

