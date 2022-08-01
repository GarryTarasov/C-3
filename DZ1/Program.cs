// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Console.WriteLine("Введите пятизначное число");

Console.WriteLine("Введите пятизначное число");
int PolNumb = Convert.ToInt32(Console.ReadLine());
string str;
while (PolNumb > 0)

   str = (PolNumb % 10) + str;  
   PolNumb = PolNumb /10;  
