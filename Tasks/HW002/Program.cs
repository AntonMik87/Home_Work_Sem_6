// Задать двумерный массив следующим правилом: Aₘₙ = m+n A[i,j] = i+j

int[,] array = new int[10, 10];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i+j;
        Console.Write($" {array[i, j]}\t ");
    }
Console.WriteLine();
}



//    0 1 2 3  
 
// 0  0 0 0 0   0 1 2 3
// 1  0 0 0 0   1 2 3 4
// 2  0 0 0 0   2 3 4 5
// 3  0 0 0 0   3 4 5 6