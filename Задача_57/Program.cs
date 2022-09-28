// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
Console.WriteLine();
List<int> @checked = WhatElements(numbers);
ElementCounter(numbers, @checked);

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


List<int> WhatElements(int[,] numbers) // пробегается по матрице и вписывает в лист встречающиеся значения
{
    List<int> @checked = new List<int>();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (!@checked.Contains(numbers[i, j])) // если не содержится
            {
                @checked.Add(numbers[i, j]);
            }
        }
    }
    return @checked; // собака тут нужна для экранирования зарезервированного имени 
}


void ElementCounter(int[,] numbers, List<int> @checked) // теперь просим пройтись по матрице и сравнить с листом
{
    foreach (int element in @checked) // для каждого (уникального) элемента в листе
    {
        int counter = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (element == numbers[i, j])
                {
                    counter++; // если встречаем элемент - плюсуем
                }
            }
        }
        Console.WriteLine($"Элементов, равных {element} в данной матрице: {counter}.");
    }
}  // O(n^3)