//1. создаем изначальный массив с размерностью n с вводом от пользователя
string[] first_array = new string [GetNumberFromUser("Введите размер массива: ")];
Console.WriteLine(first_array.Length);
//2. заполняем массив произвольными данными от пользователя
FillArray(first_array);
Console.WriteLine(first_array[0]);
Console.WriteLine(first_array[1]);
Console.WriteLine(first_array[2]);
//Методы
//Получаем число от пользователя
int GetNumberFromUser (string message) 
{
    while(true) 
    {

        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        while(isCorrect)
            return number;
        Console.WriteLine("Ошибка ввода!");
    }
}

void FillArray (string [] first_array) 
{ 
    int i = 0;
    while (i < first_array.Length) 
    {
        Console.WriteLine($"Введите {i+1}-е значение из {first_array.Length}");
        first_array[i] = Console.ReadLine() ?? "";
        i=i+1;
        if (i==first_array.Length)
            break;
    }

}