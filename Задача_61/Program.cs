// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного 
// треугольника

Console.Clear();

int row = InputNumber("Введите кол-во строк от 0 до 10: ");

int[,] pascalTriangle = new int[row + 1, 2 * row + 1]; 

FillPascalTriangle(pascalTriangle);
// Print2DArray(pascalTriangle);

Console.WriteLine();
JustificationPascalTriangle(pascalTriangle);
Print2DArray(pascalTriangle);


int InputNumber(string input)
{
      Console.Write(input);
      int output = int.Parse(Console.ReadLine()!);
      return output; 
}


int[,] FillPascalTriangle(int[,] array)
{
      for (int k = 0; k < array.GetLength(0); k++)
      {
            array[k, 0] = 1;

      }
      
      for (int i = 1; i < array.GetLength(0); i++)
      {
            for (int j = 1; j < i + 1; j++)
            {
                  array[i, j] = array[i -1, j] + array[i - 1, j - 1];
            }
      }
      return array;
}

void JustificationPascalTriangle(int[,] array)
{
      for (int i = 0; i < array.GetLength(0); i++)
      {
            int count = 0;
            for (int j = array.GetLength(1) - 1; j >= 0; j--)
            {
                  if (array[i, j] != 0)
                  {
                        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                        array[i, j] = 0;
                        count ++;
                  }
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
