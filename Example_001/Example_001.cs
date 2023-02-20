Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++ )
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SwapToRow(int[,] arrayNew)
{
    for (int j = 0; j < arrayNew.GetLength(1);)
    {
        int temp = arrayNew[0, j];
        arrayNew[0, j] = arrayNew[arrayNew.GetLength(0) - 1, j];
        arrayNew[arrayNew.GetLength(0) - 1, j] = temp;
    } 
}

Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

Console.WriteLine();

SwapToRow(array2D);
PrintArray(array2D);