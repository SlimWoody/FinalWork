// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести с
//   клавиатуры, либо задать на старте выполнения алгоритма. 
//   При решении не рекомендуется пользоваться коллекциями, 
//   лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] matrix = new string[6] { "Hello", "2", "world", ":-)", "123", "Rus" };
PrintMatrix(matrix, "Исходный массив ");
string[] newMatrix = ThreeAndLesSymbol(matrix);
PrintMatrix(newMatrix, " --> ");

string[] ThreeAndLesSymbol(string[] matrix)
{
    int index = 0;
    int count = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= 3) count++;
    }

    string[] newMatrix = new string[count];

    for (int j = 0; j < matrix.Length; j++)
    {
        if (matrix[j].Length <= 3)
        {
            newMatrix[index] = matrix[j];
            index++;
        }
    }
    return newMatrix;
}

void PrintMatrix(string[] matrix, string text)
{
    Console.Write($"{text}[");
    for (int i = 0; i < matrix.Length; i++)
    {
        if (i < matrix.Length - 1) Console.Write($"'{matrix[i]}', ");
        else Console.Write($"'{matrix[i]}'");
    }

    Console.Write("]");
}