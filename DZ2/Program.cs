// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int[] Point = new int[2];
Console.WriteLine("Введите координату по 'X'");
Point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по 'Y'");
Point[1] = Convert.ToInt32(Console.ReadLine());