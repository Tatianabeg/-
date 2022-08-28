Console.WriteLine("size array");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("array");
printArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z]  > max)
      {
        max = numbers[z];
      }
    if (numbers[z] < min)
      {
        min = numbers[z];
      }
}

    Console.WriteLine($"{numbers.Length}");
    Console.WriteLine($"{max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void printArray(double[] numbers)

{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write(']');
    Console.WriteLine();
}






