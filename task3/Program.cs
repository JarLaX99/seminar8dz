void main()
{
    int row = ReadInt("Введите кол-во строк первого массива : ");
    int col = ReadInt("Введите кол-во столбцов первого массива : ");
    int[,] matrixA = FullArray(row, col);
    int[,] matrixB = FullArray(col, row);
    int[,] resultMatrix = MatrixMultiplication(matrixA, matrixB, row);
    PrintMatrix(matrixA);
    PrintMatrix(matrixB);
    PrintMatrix(resultMatrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FullArray(int row = 5, int col = 5, int leftRange = 1, int rightRange = 10)
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
    System.Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB, int row)
{
    int[,] result = new int[row, row];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }

    }
    return result;
}

main();