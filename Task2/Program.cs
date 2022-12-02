/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

Random rnd = new Random(); // если у нас только левая часть, то по умолчанию там Null
int number = rnd.Next(100, 1000);
Console.WriteLine($"Число равно: {number}");
int hungreds = number / 100;
int ones = number % 10;

int result = (hungreds * 10) + ones;
Console.WriteLine($"результат равен {result}");