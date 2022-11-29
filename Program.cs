//1. создаем изначальный массив с размерностью n с вводом от пользователя
string[] first_array = new string [GetNumberFromUser("Введите размер массива: ")];

//2. заполняем массив произвольными данными от пользователя
FillArray(first_array);

//3. заполняем новый массив, который будет включать в себя только значенияс 3-мя и менее символами
string [] result_array = FillArrayWithBord(first_array);


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
//Заполняем изначальный массив
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
//Считаем значения с ограничением по кол-ву символов
string [] FillArrayWithBord(string[] array)
{
    //Определяем кол-во символов для границы
    int max_border_symbol = GetNumberFromUser("Введите количество символов для ограничения: ");
    string [] array_method = new string [GetMaxBorder(array,max_border_symbol)];
    int final_place = 0;
    for (int i = 0; i < array.Length; i=i+1)
    {
        if (array[i].Length<=max_border_symbol)
        {
            array_method[final_place] = array[i];
            final_place = final_place+1;
        }
    }

    return array_method;
}
//Считаем кол-во записей удовлетворяющих условию
int GetMaxBorder (string [] array, int max_border_symbol) 
{
    int max_border = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=max_border_symbol)
            max_border = max_border + 1;
    }

    return max_border;
}