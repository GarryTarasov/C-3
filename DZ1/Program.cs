// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



Console.WriteLine("Введите пятизначное число");
int PolNumb = Convert.ToInt32(Console.ReadLine());
int temp = PolNumb;
int rev = 0;
if(PolNumb<=99999 && PolNumb>9999){

while (PolNumb > 0){

int dig = PolNumb % 10;
rev = rev * 10 + dig;
PolNumb = PolNumb /10;
}
if (temp == rev)
{
    Console.WriteLine("Это палиндром!");
}
else
    Console.WriteLine("Это не палиндром!");
}
else Console.WriteLine("Введено не пятизначное число. Хотя я, наверно, смог бы проверить любое. Но увы-такие условия задачи");






