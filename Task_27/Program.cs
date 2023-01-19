/* Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе 
452 -> 11
82 -> 10
9012 -> 12 */

int num = GetNumbetFromUser("Введите целоечисло А: ", " Ошибка ввода!");
int sumNumbers = GetResultNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

int GetNumbetFromUser(string message, string errorMessage)
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

int GetResultNumbers(int numbers)

{
    int count = 0;
    int sum = 0;
    while (numbers > 0)
    {
        sum = sum + numbers % 10;
        numbers = numbers / 10;
        count++;
    }
    return sum;
}
