Console.Clear();
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// НАЧАЛО КОДА ЗАДАЧИ 47


double[,] New2DArray()
{
    Console.Write($"количество строк -> ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write($"количество колонок -> ");
    int coll = Convert.ToInt32(Console.ReadLine());

    double[,] new2DArray = new double[rows, coll];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < coll; j++) new2DArray[i, j] = new Random().Next(0, 99) + new Random().NextDouble();
    return new2DArray;
}

void PechatNew2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]:f2} | ");
        Console.WriteLine();  // следующая строка
    }
    Console.WriteLine(); // отступаем от массива 1 строчку
}

double[,] new2dArray = New2DArray();
PechatNew2DArray(new2dArray);


// КОНЕЦ КОДА ЗАДАЧИ 47

//------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// НАЧАЛО КОДА ЗАДАЧИ 50

/*
int[,] New2DArray()
{
    Console.Write($"количество строк -> ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write($"количество колонок -> ");
    int coll = Convert.ToInt32(Console.ReadLine());

    int[,] new2DArray = new int[rows, coll];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < coll; j++) new2DArray[i, j] = new Random().Next(0, 99);
    return new2DArray;
}

void PechatNew2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} | ");
        Console.WriteLine();  // следующая строка
    }
    Console.WriteLine(); // отступаем от массива 1 строчку
}

int[,] new2dArray = New2DArray();
PechatNew2DArray(new2dArray);

int rows = new2dArray.GetLength(0);
int colls = new2dArray.GetLength(1);

Console.WriteLine("ща будем искать значение элемента массива по его координатам:");
Console.Write("строка элемента -> ");
int m = Convert.ToInt32(Console.ReadLine());
while (m > rows)
{
    Console.WriteLine($"такого элемента нет. у нас всего {rows} строк. вводи заново номер строки -> ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("колонка элемента-> ");

int n = Convert.ToInt32(Console.ReadLine());
while (n > colls)
{
    Console.WriteLine($"такого элемента нет. у нас всего {colls} колонок. вводи заново номер строки -> ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"его значение -> {new2dArray[m-1,n-1]}");
*/

// КОНЕЦ КОДА ЗАДАЧИ 50

//------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// НАЧАЛО КОДА ЗАДАЧИ 52

/*

int[,] New2DArray()
{
    Console.Write($"количество строк -> ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write($"количество колонок -> ");
    int coll = Convert.ToInt32(Console.ReadLine());

    int[,] new2DArray = new int[rows, coll];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < coll; j++) new2DArray[i, j] = new Random().Next(0, 99);
    return new2DArray;
}

void PechatNew2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"строка {i+1} -> ");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} | ");
        Console.WriteLine();  // следующая строка
    }
    Console.WriteLine(); // отступаем от массива 1 строчку
}

double AverageOfRow (int [,] array, int i)
{
    double sum = 0; // не сразу допёр, что она тоже должна быть дабл
    for (int j = 0; j < array.GetLength(1); j++) sum += array [i, j];
    double avg = sum / array.GetLength(1);
    return avg;
}

int[,] new2dArray = New2DArray();
PechatNew2DArray(new2dArray);
int rows = new2dArray.GetLength(0);
int colls = new2dArray.GetLength(1);


for (int i = 0; i < rows; i++) Console.WriteLine($"среднее арифметическое строки {i+1} = {AverageOfRow(new2dArray, i)}");

*/

// КОНЕЦ КОДА ЗАДАЧИ 52