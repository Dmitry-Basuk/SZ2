/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

string IsItSquare(int numberOne , int numberTwo)
{
    if (numberTwo * numberTwo == numberOne || numberOne * numberOne == numberTwo)
    {
        return "Yes";
    }
    else
    {
        return "No";
    }
}
int numberOne = GetNumberFromConsole("Введите число");
int numberTwo = GetNumberFromConsole("Введите число");

Console.WriteLine(IsItSquare(numberOne , numberTwo));
