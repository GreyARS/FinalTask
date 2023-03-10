// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна трём символам.
// Первоначальный массив можно ввести клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int n = 3;
int size = 6;
string[] firstArray = new string[size];
Console.WriteLine($"Введите элемент массива {size} раз: ");
// FillArray(arrayOne);
FillRandomArray(firstArray);
Console.Clear();
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine($"Новый массив с элементами, размер которых меньше либо равен {n}:");

if(GetSizeOfSecondArray(firstArray) == 0)
{   
    Console.WriteLine("Нет элементов для переноса в новый массив.");
}
else
{
    string[] secondArray = TransferElements(firstArray);
    PrintArray(secondArray);
}

void FillRandomArray(string[] arr)
{
    Random rand = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for(int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(0,7);
        for(int j = 0; j <= randElemSize; j++)
        {
            arr[i] += AllSymbols[rand.Next(0, AllSymbols.Length)];
        }
    }
}

void FillArray(string[] arr)
{
    for(int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] arr)
{
    int arrLength = arr.Length;
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSizeOfSecondArray(string[] arr)
{
    int secondSize = 0;
    for(int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElements(string[] arr)
{
    string[] secondArray = new string[GetSizeOfSecondArray(firstArray)];
    for(int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondArray[j] = arr[i];
            j++;
        }
    }
    return secondArray;
}