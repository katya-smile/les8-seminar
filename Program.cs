// ДЗ
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next (1, 10);
        }
    }
}
void SortNumbers(int[,] array )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
SortNumbers(array);
Console.WriteLine();
PrintArray(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,]array=new int[5,4];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next (1, 10);
        }
    }
}
void SumNumbers(int[,] array)
{
    int minLine = 0;
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minLine += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"{minSumLine + 1} строка");
}
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine("Cтрока с наименьшей суммой елементов :");
SumNumbers(array);
Console.WriteLine();


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,]array1 = new int[2,2];
int[,]array2 = new int[2,2]; 
int[,]array3 = new int[2,2];

void FillArrayRandom(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next (1, 10);
        }
    }
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next (1, 10);
        }
    }
}
void PrintArray(int[,] array1,int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine("------");
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MiltiMatrix( int[,] array3, int[,] array1, int[,] array2)
{
for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      array3[i,j] = sum;
      Console.Write($"{array3[i, j]+ " "}");
    }
    Console.WriteLine();
  }
}

FillArrayRandom(array1,array2);
PrintArray(array1,array2);
Console.WriteLine("Их произведение равно:");
MiltiMatrix(array3,array1,array2);
System.Console.WriteLine();



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,]array = new int[2, 2, 2];

void FillArrayRandom(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}
void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,]array1 = new int[4,4];

void FillArraySpiral(int[,] array1)
{
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= array1.GetLength(0) * array1.GetLength(1))
    {
        array1[i, j] = num;
        if (i <= j + 1 && i + j < array1.GetLength(1) - 1) j++;
        else if (i < j && i + j >= array1.GetLength(0) - 1) i++;
        else if (i >= j && i + j > array1.GetLength(1) - 1)j--;
        else i--;
        num++;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArraySpiral(array1);
PrintArray(array1);
Console.WriteLine();



