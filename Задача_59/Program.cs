// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и 
// столбец, на пересечении которых расположен наименьший элемент массива.

Console.Clear();

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] number = new int[height, width];
Fill2DArray(number);
Print2DArray(number);
Console.WriteLine();

int[,] position = new int[1, 2];
position =  FindMinElementPosition(number, position);
// Print2DArray(position);

int[,] arrayNoLines = new int[number.GetLength(0) - 1, number.GetLength(1) - 1]; 
arrayNoLines = DeleteRowColumnMinElem(number, position, arrayNoLines);
Print2DArray(arrayNoLines);


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}


void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 2} ");
        }
        Console.WriteLine();
    }
}


int[,] FindMinElementPosition(int[,] array, int[,] position)
{
    int min = array[0,0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
                {
                min = array[i, j];
                position[0, 0] = i;
                position[0, 1] = j;
                }
        }
    }
    return position;
}


int[,] DeleteRowColumnMinElem(int[,] array, int[,] position, int[,] arrayNoLines)
{
    int k = 0, l = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (position[0, 0] != i && position[0, 1] != j)
            {
                arrayNoLines[k, l] = array[i, j];
                l++;
            }
        }

        l = 0;
        if (position[0, 0] != i)
            k++;
    }
    return arrayNoLines; 
}