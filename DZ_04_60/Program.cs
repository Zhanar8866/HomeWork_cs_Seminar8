/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Write("Введите количество строк первой стороны массива: ");
int side1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй стороны массива: ");
int side2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк третьей стороны массива: ");
int side3 = Convert.ToInt32(Console.ReadLine());

CreateArray(side1, side2, side3, 0, 100);

void CreateArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x,y,z];
    int counter = 1;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = counter;
                Console.Write($"{result[i, j, k]}({i},{j},{k})  ");
                counter+=1;
            }
        }
        Console.WriteLine();
    }
}

/* ниже программа не работает, оставляю себе, чтобы позже посмотреть

int[,,] CreateArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x,y,z];
    int[] inArray = new int[x*y*z];
    int counter = 0;
    int s = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
                inArray [counter] = result[i, j, k];
                s = ReconciliationOfNumbers (inArray, counter);
                if (s >= 1) k -=1;
                else
                {counter+=1;}
            }
        }
    }
    return result;
}

int ReconciliationOfNumbers (int[] inArray, int counter)
{
    int s = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray [counter] == inArray[i]) s=s+1;
    }
    return s;
}
*/

