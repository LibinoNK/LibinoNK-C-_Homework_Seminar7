/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 100);
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

void FindElementByPosition(int[,] matr, int rows, int cols)
{
    if (rows < matr.GetLength(0) && cols < matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (i == rows && j == cols)
                {
                    System.Console.WriteLine($"Запрашиваемое число: {matr[i, j]}");
                }
            }
        }    
    }
    else
    {
        System.Console.WriteLine("Элемента с таким индексом в массиве не существует");
    }
}

void FindElementByValue(int[,] matr, int numb)
{
    bool temp = false;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == numb)
            {
                System.Console.WriteLine($"Запрашиваемое число {numb} СУЩЕСТВУЕТ внутри массива на позиции [{i},{j}]");
                temp = true;
            }
        }
    }
    if (temp == false)
    {
        System.Console.WriteLine($"Запрашиваемого числа {numb} НЕ существует внутри массива");
    }    
}    


System.Console.Write("Введите позицию (индекс) искомого числа по вертикали (номер строки): ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите позицию (индекс) искомого числа по горизонтали (номер столбца): ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] matrix = FillMatrix(3, 4); // - задаем размер массива сразу, для упрощения, поскольку иначе слишком много данных придется вводить с клавиатуры (можно было сделать с вводом размера массива пользователем)
PrintMatrix(matrix);

System.Console.WriteLine();
FindElementByPosition(matrix, m, n);

System.Console.Write("Введите число, которое необходимо найти: ");
int number = Convert.ToInt32(Console.ReadLine());

FindElementByValue(matrix, number);