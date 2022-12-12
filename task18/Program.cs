/* Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). */

System.Console.WriteLine("Enter quater number");
int num = int.Parse(Console.ReadLine()!);

if (num > 4)
{
    System.Console.WriteLine("Plane does not exist");
}
if (num == 1)
{
    System.Console.WriteLine("Coordinate X: from 0 to +OO. Coordinate Y: from 0 to +OO");

}
if (num == 2)
{
    Console.WriteLine("Coordinate X: from 0 to -OO. Coordinate Y: from 0 to +OO");

}
if (num == 3)
{
    System.Console.WriteLine("Coordinate X: from 0 to -OO. Coordinate Y: from 0 to -OO");

}
if (num == 4)
{
    System.Console.WriteLine("Coordinate X: from 0 to +OO. Coordinate Y: from 0 to -OO");

}
