// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();
int[,] arr = new int[3, 3]; //{ { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($" {arr[i, j]} ");

    }
    Console.WriteLine();
}
Console.WriteLine();

for (int x = 0; x < arr.GetLength(0); x++)
{
    for (int y = 0; y < arr.GetLength(1); y++)
    {

        if (x % 2 == 0 && y % 2 == 0)
        {

            arr[x, y] = arr[x, y] * arr[x, y] * arr[x, y];
            //Console.Write($" {arr[x, y]} ");
        }
        Console.Write($" {arr[x, y]} ");
    }
    Console.WriteLine();
}

//    0 1 2 3  

// 0  0 0 0 0   
// 1  0 0 0 0   
// 2  0 0 0 0   
// 3  0 0 0 0 