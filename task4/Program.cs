// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void main()
{
    int X = ReadInt("Введите X : ");
    int Y = ReadInt("Введите Y : ");
    int Z = ReadInt("Введите Z : ");
    int[,,] matrix = new int[X, Y, Z];
    FullArray(matrix);
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FullArray(int[,,] matrix, int leftRange = 10, int rightRange = 99)
{
    if (matrix.Length > 90)
    {
        System.Console.WriteLine("Данный массив невозможно сгенерировать неповторяющимися двухзначными числами ");
        return;
    }
    else
    {
        Random rand = new Random();
        int[] array = new int[90];
        int num = 10;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = num;
            num++;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    num = array[rand.Next(array.Length)];
                    matrix[i, j, k] = num;
                    int Index = Array.IndexOf(array, num);
                    array = array.Where((v, i) => i != Index).ToArray();
                }
            }
        }
        return;
    }
}

void PrintMatrix(int[,,] matrix)
{
    if (matrix.Length > 90)
    {
        return;
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}
main();