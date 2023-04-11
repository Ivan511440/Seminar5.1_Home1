// Задайте массив заполненный случайными, положительными, трехзначными числами.
// Напишите программу которая, покажет количество четных чисел в массиве.

// [345, 897, 568, 234] → 2

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max=int.Parse(ReadLine()!);
int[] Array = GetArray(length, min, max);
WriteLine($"[{string.Join(" , " , Array)}]");
FindEven(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random(); // переменная генератор случайных чисел
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++ )
    {
       result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindEven(int[] MyArray)
{
    int even=0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i]%2==0)
        {
            even=even+1;
        }
    }
    WriteLine($"Четных чисел {even}");
}
