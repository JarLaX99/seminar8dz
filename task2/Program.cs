// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void main()
{
    int row = ReadInt("Введите кол-во строк массива : ");
    int col = ReadInt("Введите кол-во столбцов массива : ");
    int[,] matrix = FullArray(row, col);
    PrintMatrix(matrix);
    MinimumSumString(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FullArray(int row = 6, int col = 3, int leftRange = 1, int rightRange = 10)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void MinimumSumString(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int iMin = 0;
    for (int k = 1; k < sum.Length; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum[i] += matrix[i, j];
            }
        }
        if (sum[iMin] > sum[k]) iMin = k;
    }
    System.Console.WriteLine($"{iMin + 1} строка с наименьшей суммой элементов");
}

main();