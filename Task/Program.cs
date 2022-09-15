// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(string[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = PromptString("Enter the string > ");
        index++;
    }
}

void PrintArray(string[] col) //void значит не возвращает значения
{
    int length = col.Length;
    int index = 0;
    Console.Write("["); // для красивого вывода
    while (index < length - 1)
    {
        Console.Write($"{col[index]}, "); //для красивого вывода
        index++;
    }
    while (index > length - 2 && index < length) // для красивого вывода
    {
        Console.Write($"{col[index]}");
        break;
    }
    Console.Write("]"); // для красивого вывода
}

int PromptInt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

string PromptString(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    string result = readValue; // Преобразует строку в целое число
    return result; // Возвращает результат
}

string[] newArray(string[] arr)
{
    int index = 0;
    int count = 0;
    for (index = 0; index < arr.Length; index++) //Determins the new array length
    {
        string s = arr[index];
        int len = s.Length;
        if (len <= 3)
        {
            count++;
        }
    }

    string[] threeArray = new string[count]; // Fills the new array
    int threeIndex = 0;
    index = 0;
    while (index < arr.Length)
    {
        string s = arr[index];
        int leng = s.Length;
        if (leng <= 3)
        {
            threeArray[threeIndex] = arr[index];
            threeIndex++;
        }
        index++;
    }
    return threeArray;
}



string[] array = new string[PromptInt("Enter the length of the array > ")];
FillArray(array);
PrintArray(array);
string[] newArr = newArray(array);
PrintArray(newArr);
