// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Math.Abs(Convert.ToInt32(value));
    return result;
}

bool validateFiveDigitNum (int number)
{
    if (number > 9999 && number < 100000)
    {
        return true;
    }
    Console.WriteLine("It's not a five-digit number");
    return false;
}

int number = Prompt("Enter a five-digit number: ");
// int number1 = number;
if (validateFiveDigitNum(number))
{
    if(number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
    {
        Console.WriteLine($"{number} -> This is a palindrome");
    }
    else
    {
        Console.WriteLine("This number is not a palindrome");
    }
}



