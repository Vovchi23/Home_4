/*Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


Console.Clear();
int[] array = new int[8];

void GetArray(int[] data)
{
    int length = data.Length;
    int index = 0;
    while (index < length)
    {
        data[index] = new Random().Next(1, 100);
        index++;
    }
}
void PrintArrayFirst(int[] printDataFirst)
{
    int result1 = printDataFirst.Length;
    int position1 = 0;
    while (position1 < result1 - 1)
    {
        Console.Write($"{printDataFirst[position1]}, ");
        position1++;
    }
    Console.Write($"{printDataFirst[position1]}");
    Console.Write(" --->");
}
void PrintArraySecond(int[] printDataSecond)
{
    int result2 = printDataSecond.Length;
    Console.Write(" [");
    for (int position2 = 0; position2 < result2; position2++)
    {
        Console.Write($"{printDataSecond[position2]}");
        if (position2 < result2 - 1) Console.Write(", ");
    }
    Console.Write("]");
}

/* void PrintArraySecond(int[] printDataSecond)
{
    int result2 = printDataSecond.Length;
    int position2 = 0;
    Console.Write(" [");
    while (position2 < result2 - 1)
    {
        Console.Write($"{printDataSecond[position2]}, ");
        position2++;
    }
    Console.Write($"{printDataSecond[position2]}");
    Console.Write("]");
} */

GetArray(array);
PrintArrayFirst(array);
PrintArraySecond(array);
