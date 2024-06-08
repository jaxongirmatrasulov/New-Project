using System;

int radius;
decimal pi = 3.14m;
Console.WriteLine("Radius qiymatini kirit");
string inputAge = Console.ReadLine();
radius = Convert.ToInt32(inputAge);
decimal overal = pi * radius * radius;
Console.WriteLine(overal);
