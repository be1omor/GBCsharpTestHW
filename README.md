# __*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*__


**Метод для получения строковых данных от пользователя**

string Prompt(string message)

{

    Console.Write(message);
    string item = Console.ReadLine();
    return item;
    
}

**Метод для вывода на экран массива строковых данных**

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

**Метод для создания массива и заполнение его строковыми данными от пользователя**

string[] GetArray()
{
    string[] res = new string[] {};
    int i =0; 
    while (i>= 0)
    {
        string item = Prompt("Введите значение или нажмите клавишу Q: ");
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

**Метод который получает некоторый массив строковых данных, проверяет элементы этого массива на количество символов и заполняет новый массив подходящими элементами, в конце возвращает получившийся массив**

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

**Обращение к методам**

string[] array = GetArray();
PrintArray(array);
string[] array1 = LengthElement(array);
Console.WriteLine();
PrintArray(array1);