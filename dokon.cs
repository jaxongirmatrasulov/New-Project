using System;

//DOKONDA QANCHA MAHSULOT QOLDI

int nokia ;
int samsung ;
int iphone ;

Console.WriteLine("Mahsulotlarni sonini kiriting.");
Console.Write("Nokia: ");

string phoneNokia = Console.ReadLine();

nokia = Convert.ToInt32(phoneNokia);

Console.Write("Samsung: ");

string phoneSamsung = Console.ReadLine();

samsung = Convert.ToInt32(phoneSamsung);

Console.Write("Iphone: ");

string phoneIphone = Console.ReadLine();

iphone = Convert.ToInt32(phoneIphone);

bool nokia1 = nokia > 50 ;
bool nokia2 = nokia <= 50 ;
bool samsung1 = samsung > 50 ;
bool samsung2 = samsung <= 50 ;
bool iphone1 = iphone > 50 ;
bool iphone2 = iphone <= 50 ;

if(nokia1)
{
    Console.WriteLine("mahsulot yetarli");
}
else if(nokia2)
{
    Console.WriteLine("mahsulot kerak");
}
else if(samsung1)
{
    Console.WriteLine("mahsulot yetarli");
}
else if(samsung2)
{
     Console.WriteLine("mahsulot kerak");
}
else if(iphone1)
{
     Console.WriteLine("mahsulot yetarli");
}
else if(iphone2)
{
    Console.WriteLine("mahsulot kerak");
}
