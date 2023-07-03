// Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double[] GenerateArray()
{
    double[] list1 = new double[5];
    Random rnd = new Random();
    
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(0,100) + rnd.NextDouble();
    }
    return list1;
}

void PrintArray(double[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        Console.Write(Arrey[i] + "  ");
    }
}

double[] list1 = GenerateArray();


double min = list1[0];
double max = 0;
for (int i = 0; i < list1.Length; i++)
{
    if(min > list1[i])
    {
        min = list1[i];
    }
   
    if (max < list1[i])
    {
        max = list1[i];
    }
   
}

PrintArray(list1);
System.Console.WriteLine($"min = {min} max = {max}, разница между элементами массива = {max-min}");