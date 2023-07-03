// Задача 2: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int numberint()
{
    Console.WriteLine("Введите длинну массива >");
    string number = Console.ReadLine();
    int number2 = Convert.ToInt32(number);
    return number2;
}

int[] GenerateArray(int len, int min, int max)
{
    int[] answer = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max+1);
    }
    return answer;
}

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        Console.Write(Arrey[i] + "  ");
    }
    Console.WriteLine();
}

int SumNegativePosition(int[] array)
{
    int sum = 0;
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i == even)
        {
            sum = sum + array[i];
            even += 2;
        }
    }
        return sum;
}

int num = numberint();
int[] array = GenerateArray(num,0,99);
PrintArray(array);
Console.WriteLine($"сумма эелементов стоящих на нечетных позициях {SumNegativePosition(array)}");