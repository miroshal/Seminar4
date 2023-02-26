// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void NumArray(int[] number)
{
    int lenght = number.Length;
    int index = 0;
    while(index < lenght)
    {
        number[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] numb)
{
    int count = numb.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(numb[position]);
        position++;
    }
}
int[] array = new int[8];
NumArray(array);
PrintArray(array);