//возвращает рандомное число от a до b
int GetRandomNumber(int a, int b)
{
    Random rnd = new Random();

    int result = rnd.Next(a, b + 1);

    return result;
}

//получает наибольшую цифру числа number
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if(firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number =GetRandomNumber(10,99);

Console.WriteLine($"Рандомное число = {number}");

int maxDigitOfNumber = GetMaxDigitOfNumber(number);

Console.WriteLine($"Наибольшая цифра числа {number} = {maxDigitOfNumber}");