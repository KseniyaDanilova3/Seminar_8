// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
Console.WriteLine();
ChangeFirstEndRows(numbers, height, width);
Print2DArray(numbers, height, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}


void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}


void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j], 2} ");
        }
        Console.WriteLine();
    }
}


void ChangeFirstEndRows(int[,] numbers, int height, int width)
{
    for (int j = 0; j < width; j++)
    {
        (numbers[0, j], numbers[height - 1, j]) = (numbers[height - 1, j], numbers[0, j]);
    } 
}
