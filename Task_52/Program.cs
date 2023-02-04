/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 11);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] matr)
{
    double[] allResult = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            allResult[i] += matr [j, i];
        }
    }

    for (int i = 0; i < allResult.Length; i++)
    {
        allResult[i] = Math.Round(allResult[i]/matr.GetLength(0), 2);
    }
    return allResult;
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] matrix = FillMatrix(rows, cols);
System.Console.WriteLine("Заданный массив: ");
PrintMatrix(matrix);
System.Console.WriteLine();
double[] ArithmeticMeanMatrix = ArithmeticMean(matrix);
System.Console.WriteLine("Среднее арифметическое столбцов массива: [" + string.Join("; ", ArithmeticMeanMatrix) + "]");