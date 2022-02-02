// Итоговая проверочная работа.
int[] array = new int[10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-50, 50);
    Console.Write(array[i]);
    Console.Write(" ");
}
Console.WriteLine(" ");

int[] rightNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 8)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }
    return array;
}
rightNumbers(array);
