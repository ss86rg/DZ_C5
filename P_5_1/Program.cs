// Задача 1: Задайте массив заполненный случайными
 //положительными трёхзначными числами. 
 //Напишите программу, которая покажет количество чётных 
 //чисел в массиве.
//[345, 897, 568, 234] -> 2


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

int evenNumber (int[] Array)
{
    int number2 = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i] %2 == 0)
        {
        number2 = number2 + 1;
        }
    }
    return number2;

}
 int num = numberint();
 int[] numberlist = GenerateArray (num, 100, 1000);
 int even = evenNumber(numberlist);

 PrintArray(numberlist);
 Console.WriteLine($"колличество четных чисел = {even}");

