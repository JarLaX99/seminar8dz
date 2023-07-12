// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void main()
{
    int row = ReadInt("Введите кол-во строк массива : ");
    int col = ReadInt("Введите кол-во столбцов массива : ");
    int[,] matrix = FullArray(row, col);
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FullArray(int row, int col)
{
    int[,] matrix = new int[row, col];
    int startRow = 0;
    int endRow = row - 1;
    int startCol = 0;
    int endCol = col - 1;
    int counter = 1;
    int end = row * col;

    while (counter < end)
    {
        for (int i = startCol; i < endCol; i++)
        {
            matrix[startRow, i] = counter;
            counter++;
        }
        for (int i = startRow; i < endRow; i++)
        {
            matrix[i, endCol] = counter;
            counter++;
        }
        for (int i = endCol; i > startCol; i--)
        {
            matrix[endRow, i] = counter;
            counter++;
        }
        for (int i = endRow; i > startRow; i--)
        {
            matrix[i, startCol] = counter;
            counter++;
        }
        startRow++;
        startCol++;
        endCol--;
        endRow--;
        if (row == col && startCol == endCol)
        {
            matrix[startCol, endCol] = row * col;
        }
        if (row < col && startCol == endCol)
        {
            matrix[startRow -= 1, startCol] = row * col - 1;
        }
        if (row > col && startCol == endCol)
        {
            matrix[startRow, endCol] = row * col - 2; counter++; startRow++;
        }
    }
    return matrix;
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
main();