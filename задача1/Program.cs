// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число: ");
string numberFirst = Console.ReadLine();
int number = Convert.ToInt32(numberFirst);

int firstDigit = number / 10;

int secondDigit = firstDigit - (firstDigit / 10) * 10;

Console.WriteLine($"{secondDigit}");