// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

double[,] array = GetArray(3, 4); 

Write("Введите строку элемента начиная с 0: ");
int a = int.Parse(ReadLine());
Write("Введите колонку элемента начиная с 0: ");
int b = int.Parse(ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*10-0;
            Write($"{result[i,j]:f0} ");
        }
        WriteLine();
    }
    return result;
}

if(a>2|| b>3||a<0||b<0)
{
Write("Данного элемента нет в массиве ");
}
else
{
    for (int i = 0; i < 3; i++)// проверяет циклом все индексы с вводимым значением
    {
        if(i==a)
        {
            for (int j = 0; j < 4; j++)
            {
                if(j==b)
                {
                    Write($"Искомое значение {array[i,j]:f0}");
                } 
            }
        }
    }
}


    
