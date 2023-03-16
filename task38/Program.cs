// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write ($" Введите размер массива ");
int i = Convert.ToInt32 (Console.ReadLine ());
int[] newArray = newint();
Console.WriteLine(string.Join(" ", newArray));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max() - min ()} ");


int[] newint()
{
     int[] array = new int[i];
     for (int j = 0; j < i; j++)
     {
        array[j] = Random.Shared.Next(10, 100);
     }
     return array;
}

int max ()
{
    int maximum = 0;
    int[] array = newArray;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > maximum)
        maximum = array[j];
    }
    return maximum;
}

int min ()
{
    int[] array = newArray;
    int minimum = 1000;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < minimum)
        minimum = array[j];
    }
    return minimum;
}