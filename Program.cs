using System;
using System.Diagnostics.Contracts;
//AYLANANI YUZASINI TOPISH DASTURI.
// int radius;
// decimal pi = 3.14m;
// Console.WriteLine("Radius qiymatini kirit");
// string inputAge = Console.ReadLine();
// radius = Convert.ToInt32(inputAge);
// decimal overal = pi * radius * radius;
// Console.WriteLine(overal);

//ARMIYAGA BORISH YOSHI DASTURI.
// int userAge ;
// Console.WriteLine("yosh kiriting");
// string armiya = Console.ReadLine();
// userAge = Convert.ToInt32(armiya);
// bool isMiner = userAge < 17 ;
// bool isAdult = userAge > 28 ;
// bool isPossible = userAge is 17 or 28 ;

// if(isMiner)
// {
//     Console.WriteLine("bormaysan");
// }else if(isAdult)
// {
//     Console.WriteLine("bormaysan senham");

// }else if(isPossible)
// {
//     Console.WriteLine("ariza berasan");
// }else
// {
//     Console.WriteLine("bora olasizlar");
// }


//JAHON CHEMPIONATIGA YOLLANMA DASTURI.

string teamName;
int ball;
Console.WriteLine("Jamoa nomini kiriting:");
teamName = Console.ReadLine();
Console.WriteLine("To`plagan ochqo:");
string ochqo = Console.ReadLine();
ball = Convert.ToInt32(ochqo);
bool overal1 = ball is < 10 or > 6;
bool overall = ball > 5;
bool overalll = ball == 5;

if (overal1)
{
    Console.WriteLine("siz 1-orin");
}
else if (overall)
{
    Console.WriteLine("siz 2-orin");
}
else if (overal)
{
    Console.WriteLine("siz 3-orin");
}
else
{
    Console.WriteLine("siz musobaqani tark etdingz");
}


Console.WriteLine("realmadrid chempion");