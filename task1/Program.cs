// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void main()
{
    int row = ReadInt("Введите кол-во строк массива : ");
    int col = ReadInt("Введите кол-во столбцов массива : ");
    int[,] matrix = FullArray(row, col);
    PrintMatrix(matrix);
    DescendingSort(matrix);
    System.Console.WriteLine();
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FullArray(int row = 5, int col = 5, int leftRange = -10, int rightRange = 10)
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

void DescendingSort(int[,] matrix)
{
    int save = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) ; k++)
                if (matrix[i, k] < matrix[i, j])
                {
                    save = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = save;
                }
        }

    }
}

main();