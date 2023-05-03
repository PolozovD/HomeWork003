// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int Prompt (string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Math.Abs(Convert.ToInt32(value));
//     return result;
// }

// bool validateFiveDigitNum (int number)
// {
//     if (number > 9999 && number < 100000)
//     {
//         return true;
//     }
//     Console.WriteLine("It's not a five-digit number");
//     return false;
// }

// int number = Prompt("Enter a five-digit number: ");
// // int number1 = number;
// if (validateFiveDigitNum(number))
// {
//     if(number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
//     {
//         Console.WriteLine($"{number} -> This is a palindrome");
//     }
//     else
//     {
//         Console.WriteLine("This number is not a palindrome");
//     }
// }


// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance(double xa, double ya, double xb, double yb, double za, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(((xb) - (xa)), 2) + Math.Pow(((yb) - (ya)), 2) + Math.Pow(((zb) - (za)), 2)), 2);
// }

// Console.WriteLine("Input coordinate x to A: ");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y to A: ");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate z to A: ");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate x to B: ");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y to B: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate z to B: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A with coordinates ({xa},{ya},{za}) and point B with coordinates ({xb},{yb},{zb}) -> {FindDistance(xa, ya, xb, yb, za, zb)}");


// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Input number: ");
// int countNumber = Convert.ToInt32(Console.ReadLine());

// void Cube(int number)
// {
//     int i = 1;
//     while (i <= number)
//     {
//         Console.WriteLine($"{i} -> {i*i*i}");
//         i++;
//     }
// }

// Cube(countNumber);
