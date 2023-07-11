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
    int[,,] matrix = FullArray(X, Y, Z);
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] FullArray(int X = 5, int Y = 5, int Z = 5, int leftRange = 10, int rightRange = 99)
{
    int[,,] tempMatrix = new int[X, Y, Z];
    Random rand = new Random();
    int n = 10;
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            for (int k = 0; k < Z; k++)
            {
                tempMatrix[i, j, k] = n;
                n++;
                int t= rand.Next(j+1);
                var temp = tempMatrix[i,t,k];
                tempMatrix[i,t,k]=tempMatrix[i,j,k];
                tempMatrix[i,j,k]= temp;
            }
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,,] matrix)
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
        if(matrix.Length>99)
    {
     System.Console.WriteLine("Данный массив невозможно сгенерировать неповторяющимися двухзначными числами ");
    }
}
main();