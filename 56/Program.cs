void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [0, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void SumOfString(int[,] matrix)
{
    int sum1 = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum1 += matrix[0, j];
    }
    int minSum = sum1;
       
    int minString=0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        
        if (sum < minSum)
        {
            minSum = sum;
            minString=i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {minString+1}");
    Console.WriteLine($"Наименьшая сумма - {minSum}");
}

Console.Clear();
Console.WriteLine("Введите размер двухмерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.WriteLine("Вы ошиблись.\nВведите размер двухмерного массива:");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
SumOfString(matrix);