// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine ("Введите количество строк 1 матрицы: ");
int lines1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите количество столбцов 1 матрицы: ");
int columns1 = Convert.ToInt32 (Console.ReadLine());

int lines2 = columns1;
int columns2 = lines1;

Console.WriteLine("Матрица 1: ");
int[,] array1 = new int[lines1, columns1];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = new Random().Next(-50, 51);
        Console.Write (array1[i, j] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Матрица 2: ");
int[,] array2 = new int[lines2, columns2];

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(-50, 51);
        Console.Write (array2[i, j] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine(" ");
Console.WriteLine("Произведение матриц:  ");

    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array3 [i,j] += array1 [i,k] * array2 [k,j];
            }
        Console.Write (array3[i, j] + "\t");

         }
    Console.WriteLine();
    }