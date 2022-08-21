void FillArray(int[] collection) //Метод заполнения массива случайными числами
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) //Метож вывода массива в консоль
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++; 
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);