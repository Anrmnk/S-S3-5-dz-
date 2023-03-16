// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write ($" Введите размер массива ");
int i = Convert.ToInt32 (Console.ReadLine ());
int[] newArray = newint();
Console.WriteLine(string.Join(" ", newArray));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res()} ");

int[] newint()
{
     int[] array = new int[i];
     for (int j = 0; j < i; j++)
     {
        array[j] = Random.Shared.Next(10, 100);
     }
     return array;
}

int res()
{
    int result = 0;
    int[] array = newArray;
    for (int j = 0; j < array.Length; j++)
    {if (j % 2 != 0)
    {
        result = result + array[j];
    }
    }
    return result;
}
