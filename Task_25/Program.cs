

int numA = GetNumbetFromUserA("Введите целоечисло А: ", " Ошибка ввода!");
int numB = GetNumbetFromUserB("Введите целоечисло B: ", " Ошибка ввода!");
int resultNumbers = GetResultNumbers(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {resultNumbers}");

int GetNumbetFromUserA(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int GetNumbetFromUserB(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetResultNumbers(int num1, int num2)
{
    int multiply = 1;
    int count = 1;
    while (count <= num2)
    {
        multiply = multiply * num1;
        count++;
    }
    return multiply;
}

