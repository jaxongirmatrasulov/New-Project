using System;
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


//IMTIXONDAN O`TISH DASTURI.

// string boys ;
int ballBoys ;
// string girls ;
// int ballGirls ;

Console.WriteLine("Yigitlaar malumotlari");
Console.Write("Ball boys: ");
string man = Console.ReadLine();
ballBoys = Convert.ToInt32(man);
bool overal = ballBoys > 5;
bool overall = ballBoys is 5 ;


if(overal)
{
    Console.WriteLine("siz imtihondan otdingiz");
}else if(overall)
{
    Console.WriteLine("siz qayta oqishda davom etasiz");
}else
{
    Console.WriteLine("siz ota olmadinguz");
}

