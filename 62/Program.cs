void PrintArray(int[,] spiral)
{
    for (int i = 0; i < spiral.GetLength(0); i++)
    {
        for (int j = 0; j < spiral.GetLength(1); j++)
        {
            Console.Write(spiral[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] spiral = new int[size[0], size[1]];
int start = 1;
int i = 0;
int j = 0;

while (start <= size[0] * size[1])
{
    spiral[i, j] = start;
    if (i <= j + 1 && i + j < size[0] - 1)
        j++;
    else if (i < j && i + j >= size[0] - 1)
        i++;
    else if (i >= j && i + j > size[0] - 1)
        j--;
    else
        i--;
    start++;
}
PrintArray(spiral);