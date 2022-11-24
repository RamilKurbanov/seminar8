double[,] GetArray(int row, int column, double minValue, double maxVlaue)
{
    double[,] result = new double[row, column];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            result[i,j] = Math.Round(new Random().NextDouble() * (maxVlaue - minValue) + minValue, 2);
        }
    }
    return result;
}


void PrintArray(double[,] array)
{
    Console.WriteLine("Двумерный масси: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.WriteLine($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте количество строк n = ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите нижнюю границу диапазона элементов массива:  ");
double lower = double.Parse(Console.ReadLine()!);
Console.Write("Введите верхнюю границу диапазона элементов массива:  ");
double upper = double.Parse(Console.ReadLine()!);

double[,] workingArray = GetArray(m, n, lower, upper);
PrintArray(workingArray);
