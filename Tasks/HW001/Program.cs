// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] matrix = new double[10, 10];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().NextDouble(); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write(" {0,6:F2} ", matrix[i, j]);
    }
    Console.WriteLine();
}
