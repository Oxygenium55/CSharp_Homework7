/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

double[,] InitArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = -10 + rnd.NextDouble() * (10 - (-10)); // числа с дробной частью в диапазоне (-10;10)
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)}  ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Задайте количество строк: ");
int n = GetNumber("Задайте количество столбцов: ");
double[,] array = InitArray(m, n);
PrintArray(array);

