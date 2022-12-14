/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int[] A = new int[] {7,-5,0};
int[] B = new int[] {1,-1,9};

double Numb = Math.Sqrt(Math.Pow(A[0]-B[0], 2)+
                        Math.Pow(A[1]-B[1], 2)+
                        Math.Pow(A[2]-B[2], 2));
Console.Write($"The location of the point in 3D space, taking into account the entered coordinates, will be: {Numb}");
