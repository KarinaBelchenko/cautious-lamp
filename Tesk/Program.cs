// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = new string[] { "Hello", "2", "world", ":-)" };

void PrintArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Diffarray(string[] arr)
{
       for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
        }
        else arr[i] =  string.Empty;

    }
}

PrintArray(array);
Diffarray(array);
Console.Write("-> ");
PrintArray(array);


