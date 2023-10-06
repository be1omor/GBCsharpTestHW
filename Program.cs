// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string Prompt(string message)
{
    Console.Write(message);
    string item = Console.ReadLine();
    return item;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string[] GetArray()
{
    string[] res = new string[] {};
    int i =0; 
    while (i>= 0)
    {
        string item = Prompt("Введите элемент массива или нажмите клавишу q: ");
        if (item.ToLower() == "q") break;
        else 
        {
            Array.Resize(ref res, res.Length + 1);
            res[i] = item;
        }
        i++;
    }  
    return res;
}

string[] LengthElement(string[] arr)
{
    string[] res = new string[] {};
    int j = 0;
    foreach (var item in arr)
    {
        if (item.Length <= 3)
        {
            Array.Resize(ref res, res.Length + 1);
            res[j] = item;
            j++;
        }
    }
    return res;
}

string[] array = GetArray();
Console.Write("Ваш массив: \t");
PrintArray(array);
string[] array1 = LengthElement(array);
Console.WriteLine();
Console.Write("Новый массив: \t");
PrintArray(array1);