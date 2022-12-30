/*
Задача:
Написать программу, которая из имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный
массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.
*/
int ChooseArray(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        Console.WriteLine("1 – использовать массив: [“Hello”, “2”, “world”, “:-)”]");
        Console.WriteLine("2 – использовать массив: [“1234”, “1567”, “-2”, “computer science”]");
        Console.WriteLine("3 – использовать массив: [“Russia”, “Denmark”, “Kazan”]");
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 4)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите число от 1 до 3");
        }
    }
    return result;
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}

int n = ChooseArray("Выберите массив строк для обработки: ");
string[] array = new string[] { };
switch (n)
{
    case 1:
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case 2:
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case 3:
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{array} - Такой команды нет");
        break;
}
int newArrayLength = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) newArrayLength++;
}
string[] newArray = new string[newArrayLength];
int place = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[place] = array[i];
        place++;
    }
}
Console.WriteLine("Из выбранного массива сформирован массив по указанным условиям задачи: ");
PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);