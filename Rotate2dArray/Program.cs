var grid = new[,]
{
    { '.', '.', '.', '.', '.', '.' },
    { '.', 'O', 'O', '.', '.', '.' },
    { 'O', 'O', 'O', 'O', '.', '.' },
    { 'O', 'O', 'O', 'O', 'O', '.' },
    { '.', 'O', 'O', 'O', 'O', 'O' },
    { 'O', 'O', 'O', 'O', 'O', '.' },
    { 'O', 'O', 'O', 'O', '.', '.' },
    { '.', 'O', 'O', '.', '.', '.' },
    { '.', '.', '.', '.', '.', '.' }
};

Print2DArray(grid);
Console.WriteLine();
Print2DArray(Rotate2dArray(grid));
Console.WriteLine();
Print2DArray(Rotate2dArray(grid, 2));

Console.Write("\nPress any key to exit...");
Console.ReadKey();

char[,] Rotate2dArray(char[,] array, int rotate90DegTimesX = 1)
{
    var result = array;

    while (rotate90DegTimesX > 0)
    {
        result = Rotate90Deg(result);

        rotate90DegTimesX--;
    }

    return result;
}

static void Print2DArray<T>(T[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}

char[,] Rotate90Deg(char[,] chars)
{
    var tempResult1 = new char[chars.GetLength(1), chars.GetLength(0)];

    for (int col = 0; col < chars.GetLength(1); col++)
    {
        List<char> temRow = new List<char>();

        for (var row = chars.GetLength(0) - 1; row >= 0; row--)
        {
            temRow.Add(chars[row, col]);
        }

        for (int i = 0; i < temRow.Count; i++)
        {
            tempResult1[col, i] = temRow[i];
        }
    }

    return tempResult1;
}