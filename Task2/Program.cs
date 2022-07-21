// Програмама задаёт массив из 8 элементов и выводит их на экран.

int[] numbers = new int[8];
      
void FillArray(int[] array)
{
    for (int i = 0; i<8; i++ )
    {
        array[i] = new Random().Next(9, 99);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i<8; i++ )
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(array);
}

FillArray(numbers);
PrintArray(numbers);
