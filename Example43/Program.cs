// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

System.Console.WriteLine("Введите размерность массива: ");
int[] array = GetArray(int.Parse(Console.ReadLine()!));
System.Console.WriteLine($"[{String.Join("|",array)}]");
array = SortArray(array);
System.Console.WriteLine($"[{String.Join("|",array)}]");


//-----metods-----
int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i = 0;i<size;i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

int[] SortArray(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        int maxIndexElement = i;
        for(int j = i+1;j < array.Length;j++)
        {
            if(array[j]<array[maxIndexElement]) maxIndexElement = j;
        }
        int temp = array[i];
        array[i] = array[maxIndexElement];
        array[maxIndexElement] = temp;
    }
    return array; 
}