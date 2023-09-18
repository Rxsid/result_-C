// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо 
//равна 3 символам. Первоначальный массив можно ввести с 
//клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] String = {"Hello", "2", "world", ":-)"};
string[] newString;
newString = new string[String.Length];
int count = 0;
for (int i = 0; i < String.Length; i++)
{
    if (String[i].Length <= 3)
    {
        newString[i] = String[i];
        count++;
    }
}

for (int i = 0; i < newString.Length; i++)
{
    Console.Write(newString[i]);
}
Console.WriteLine();


