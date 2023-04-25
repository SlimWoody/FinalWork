// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, длина 
// которых меньше, либо равна 3 символам. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] matrix = new string["Hello", "2", "world", "123", "-2"];
PrintMatrix (matrix);
string[] newMatrix = ThreeCharacters (matrix);
PrintMatrix (newMatrix);



string[] ThreeCharacters(string[] matrix)
{
    string[] newMatrix = new string(matrix.Length);
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i] <= 3)
        {
            newMatrix[i] = matrix[i];
        }
    }
    return newMatrix;

}

void PrintMatrix (string[] matrix)
{   
    Console.Write("[");
    for (int i = 0; i < matrix.Length; i++)
    {
        if (i<matrix.Length-1) Console.Write($"'{arr[i]}', ");
    }
    Console.Write("]");
}