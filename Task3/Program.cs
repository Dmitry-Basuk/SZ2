/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число");
int numbreOne = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите второе число");
int numbreTwo = int.Parse(Console.ReadLine()??"");

if (numbreOne % numbreTwo == 0)
{
    Console.WriteLine($"Первле число {numberOne} кратно второму {numberTwo}");
}
else
{
    int ost = numbreOne % numberTwo;
    Console.WriteLine($"Первле число {numberOne} не кратно второму {numberTwo}, остаток от деления {ost}");
}

