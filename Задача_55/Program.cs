// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
Console.WriteLine();
ChangeRowColumn(numbers, height, width);
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


void ChangeRowColumn(int[,] numbers, int height, int width)
{
    if (height == width)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = i; j < width; j++)
            {
                Swap(ref numbers[i, j], ref numbers[j, i]);
            }
        }
    }
    else 
        Console.WriteLine("Невозможно поменять строки и столбцы местами");
}

static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }