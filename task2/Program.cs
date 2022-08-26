Task34.
Console.WriteLine("size array");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("array");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++);
if (numbers[z] % 2 == 0 )
count++;

Console.WriteLine($"{numbers.Length},{count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void printArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write(']');
    Console.WriteLine();
}






