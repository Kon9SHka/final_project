//1. создаем изначальный массив с размерностью n с вводом от пользователя
string[] first_array = new string [GetNumberFromUser("Введите размер массива: ")];


//Методы
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