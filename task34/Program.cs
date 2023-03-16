// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write ($" Введите размер массива ");
int i = Convert.ToInt32 (Console.ReadLine ());
int[] newArray = newint();
Console.WriteLine(string.Join(" ", newArray));
Console.WriteLine($"Количество четных чисел в массиве = {even()} ");


int[] newint()
{
     int[] array = new int[i];
     for (int j = 0; j < i; j++)
     {
        array[j] = Random.Shared.Next(100, 1000);
     }
     return array;
}

int even ()
{
    int [] nArray = newArray;
    int count = 0;
    for (int i = 0; i < nArray.Length; i++)
    {
    if (nArray[i] % 2 == 0)
    {
    count = count + 1;
    }
    }
    return count;
}
