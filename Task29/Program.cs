int[] a = FillArray();
PrintArray(a);



int[] FillArray()
{
    int[] array = new int[8];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 100);
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    while (i < array.Length)
    {
        Console.Write(array[i]);
        if(i != array.Length-1)
        {
            Console.Write(",");
        }
        i++;
    }
    Console.WriteLine("]");
}
