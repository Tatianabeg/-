Console.WriteLine("$ Task41. Сколько чисел больше 0 ввел пользователь \n");
Console.Write("numbers M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[M];

void InputNumbers(int M){
for (int i = 0; i < M; i++)
    {
Console.Write($" {i+1} numbers: ");
arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] arrayNumbers)
{
int count = 0;
for (int i = 0; i < arrayNumbers.Length; i++)
    {
 if(arrayNumbers[i] > 0 ) count += 1; 
  }
 return count;
}

InputNumbers(M);

Console.WriteLine($"numbers > 0: {Comparison(arrayNumbers)} ");


Console.WriteLine($" Task43.Найти точку пересечения двух прямых \n");

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
 for (int i = 0; i < coeff.GetLength(0); i++)
  {
 Console.Write($"coeff {i+1}-equation (y = k * x + b):\n");
 for (int j = 0; j < coeff.GetLength(1); j++)
    {
 if(j==0) Console.Write($" coeff k: ");
 else Console.Write($"coeff b: ");
 coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\n Прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\n Прямые параллельны");
  }
  else
  {
    Decision(coeff);
    Console.Write($" Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);
