Console.WriteLine("Task47.Bвод количеств строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод количеств столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
 array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++)
        {
 Console.Write(array[i, j] + " ");
        }
 Console.Write("]");
 Console.WriteLine("");
    }
}

Console.WriteLine("Task50.Ввод номера строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] number = new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
 Console.WriteLine("такого элемента нет");
}
else
{
 Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
        {        
 for (int j = 0; j < array.GetLength(1); j++)
            {
 array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray (int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}



Console.WriteLine( "Task52. Bвод количеств строк");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bвод количеств столбцов");
int M = Convert.ToInt32(Console.ReadLine());

int[,] number = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
 double avarage = 0;
 for (int i = 0; i < numbers.GetLength(0); i++)
    {
 avarage = (avarage + numbers[i, j]);
    }
 avarage = avarage / n;
 Console.Write(avarage + "; ");
}
Console.WriteLine();M
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
 array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

 for (int i = 0; i < array.GetLength(0); i++)
    {
 Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++)
        {
 Console.Write(array[i, j] + " ");
        }
 Console.Write("]");
 Console.WriteLine("");
 {
  }
} 
