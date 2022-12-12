/* Напишите программу, которая принимает на вход пятизначное число и
 проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */


int usernamb;
Console.Write("Enter any five digit number: ");
int.TryParse(Console.ReadLine()!, out usernamb);
if ((usernamb/10000 == usernamb%10) && (usernamb/1000%10 == usernamb/10%10))
    Console.Write($"The entered number is a polyndrom");
else 
    Console.Write($"The entered number is not a polyndrom");

