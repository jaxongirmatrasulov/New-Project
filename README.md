# uzbekiston

# 30-may C#

sdjfbsdfjbsjdfbjashfas

># 2-LESSON!

># GITHUB

**github**---> Dasturchilarning kodlarini saqlab beradigan platforma hisoblanadi. (yani **INSTAGRAM**- rasmlar uchun yaratilgani kabi **GITHUB** - ham kod uchun yaratilgan platforma.)


**github** da kodning har hil vaqtdagi har hil holatini biz **commit** deb ataymiz.

**MARKDOWN** tili bu html tili hisoblanadi.



 ># MARKDOWN

>**HEADING**- hedinglarni qanday kattalikda yozmoqchi bo`lsak wu sozimiz oldiga **"#"**  wu belgini qoyib ketishimiz kerak boladi.

>**PARAGRAPH** - paragrflar bizda juda oddiy yoziladi yani togridan-togri kerakli gaplarni "text" larni yozib ketishimz mumkin boladi va xato hisoblanmaydi.

>**BOLD TEXT**- bu bizga sozlarimizni jirniy qilib yozishda yordam beradi albatta. Buni qanday amalga oshirirhsimiz mumkin. Buning 2 xil usuli mavjud. 1-usul kerakli bo`lgan sozimizni gapimizni ** ** shunday yulduzcha korinishidagi skopka ichida yozamiz. 2-usul kerkli bolgan soz yokida gapimizni __ __ mana bunday pastki chiziqlar ichida yozsak biz hohlagan natijani yani jirniy korinishiga olib keladi.

>ITALIC *YOTIQROQ QILIB YOZISH* -(**ITALIC**) yani shunday. Bunday qilib yozish uchun biz 2 xil yoldan ketsak boladi. Bu xam jirniy qilib yozganimizga oxwab ketadi albatta. Lekin bunda biz * * , _ _ shunday yulduz va wunday chiziqlardan foydalanamiz.

># ORDERED LIST

1. DUSHANBA
2. SESHANBA
3. CHORSHANBA
4. PAYSHANBA
5. JUMA 
6. SHANBA
7. YAKSHANBA

bunday korinishdagi listlarni yani royhatlarni yaratish uchun oddiygina raqamlar bilan yozib ketamiz.

># UNORDERED LIST

* DUSHANBA
- SESHANBA
+ CHORSHANBA
* PAYSHANBA
* JUMA 
* SHANBA
* YAKSHANBA

bunday korinishdagi list yani royhat tuzishimiz uchun har bir soz oldidan  "*', "-", "+" minus, plus, yulduzcha qoyib yozishimiz kerak.

># IMAGES rasmlar bilan ishlash.

Biz rasm joylamoqchi bolsak qanday qilamiz ?

rasm yoq payti korsanadigan gap yani !["bu yerda rasm bor"](https://catherineasquithgallery.com/uploads/posts/2021-03/1614548430_1-p-kompyuter-na-belom-fone-1.png) qavslar ichida rasmning manzili beriladi.


># O`ZGARUVCHILAR 

**int**  bu faqat butun sonlarni oz ichiga oladi.

**double**  bu faqat kasr yani 10.5, 5.6 kabi sonlarni oz ichiga oladi.

**string**  bu text ni oz ichiga oladi.

**bool**  bu faqat true or false qiymatlarni oz ichiga oladi.

**char**  bu esa belgilarni oz ichiga oladi yani klaviaturadagi har qanday belgini ('a', '5', '!') va hokazo.



># GIT (KONSPEKT)

Repozitorini yuklab olish bu **GIT CLONE** deyiladi.

MISOL: git clone https://github.com/jaxongirmatrasulov/uzbekiston.git (repozitorini silkasi).

GIT BASH ni ozidan loyixaga kirish un **cd uzbeksitan** deb yoziladi va tab bosiladi.

MISOL: cd uzbekistan/ (yani bu buyuruq bn biz yaratgan papkamiz ichiga kirshimiz mumkin).

VISUAL STUDIO CODE da yozishni hohlayman degani yani vs codga otkazishimiz un biz **code .** shu buyuruqni bershimiz kerak ekan.

REMEMBER!! **code .** biz bu buyuruqni berganmizda avtomaticheski tarzda bizda vscode ochiladi.

Biz visual studioni ochganimizdan keyin bizga kerakli fayllar papkalar ochib berishi kerak buning uchun biz **dotnet new console** buyuruqini berar ekanmiz.

MISOL: dotnet new console bu bizga vs codda kerakli fayllarni ochib beradi.

Bu ketma ketliklardan keyin **dotnet run** buyuruqini git bashga beramiz va bunda ekranga bizda Hello World sozi chiqadi.

Bizdagi keyingi buyuruq bu **git status** boladi. Bu bizga qaysi fayl qanday holatda ekanligni aytib beradi.

Bizni keyingi buuruqimiz dan oldin bir narsani aytib otaman . git status bizga fayllarni qanday holatini korsatadi yani fayllar qoshilganmi yoqmi agar bizda fayllar qoshilmagan bolsa albatta qoshishimiz kerak shart. Bunda bizga yordamga keladi **git add .** buyuruqi.

Git add . bizga fayllarni qoshib bergan bolsa endi bizga fayllarni pechatla yani qanday bolsa shunday saqla deyish un bizga yordamga keladi **git commit -m "Add Project"** buyuruqi.

Bizni keyingi qiladigan ishimiz ![rasm](c:\Users\IDS\Desktop\Снимок.PNG) mana shunday oyna chiqarib beradi va bu yerda korib turganimizdek bizga user name larimizni qanday yozishni korsatib qoygan.

Keyingi va oxirgi qiladigan buyruqimiz bu **git push origin main** boladi. Bu bizga githubimizda barcha fayllarni korsatib chiqarib beradi.


**PascalCase** => har bir sozning bosh harfi katta harf bilan yoziladi.

**camelCase**  => birinchi soz kichik har bilan qolganlari katta harf bilan yoziladi.

**kebab-case** => hamma sozlar kichik harf bilan lekin ortasida chiziqcha bilan yoziladi.

**snake_case** => hammasi kichik harf bilan lekin ortada pastki chiziqcha bilan yoziladi.


># BUTUN SONLAR 

short  ->  2 byte -> 16 bit -> [ - (2^16/2);  2^16/2 ]

int    ->  4 byte -> 32 bit -> [ - (2^32/2);  2^32/2 ]

long   ->  8 byte -> 64 bit -> [ - (2^64/2);  2^64/2 ]

># MUSBAT SONLAR QABUL QILSIN DESAK

ushort  ->  2 byte -> 16 bit -> [ 0;  2^16 ]

uint    ->  4 byte -> 32 bit -> [ 0;  2^32 ]

ulong   ->  8 byte -> 64 bit -> [ 0;  2^64 ]


># BOOLEAN  XA/YOQ; MUSBAT/MANFIY;

bool  -> 1  bit ->  true, false; (1,0);

bool ni nomlashni quydagicha tavsiya qilishadi => is yoki are bilan boshlashni.

bool isArmyAge = 18 < isArmyAge ; 

bool isStudentHappy = true ; 


># STRING 

string qanchalik uzun bolishiga qarab 2 byte qoshilib boravaeradi.

string matn = "hello world";  bu matnda bzida 11 ta harf qatnashgan shuning uchun bz 11 ni 2 ga kopaytrsak qiymati kelib chiqadi yani 22 byte ga teng string.


># CHAR

char bu bitta ' '; qoshtirnoq bilan o`lchanadi yani klaviaturadagi har qanday harf son belgi hammasi char ga kiradi.

char belgi = 'a';
char belgi = '@'; 
cahr belgi = '!';

># FLOAT, DOUBLE, DECIMAL : kasr sonlar 1.5, 22.2568,5.04;

float da biz qaysi oraliqdagi sonlarni qabul qiladi deb emas qanday aniqlikdagi sonlarni oz ichiga oladi deb qarashni boshlaymiz.

float  -> 4 byte -> 32 bit -> float nuqta yoki verguldan keyin 6 son gacha aniqlikdagi sonlarni oz ichiga oladi.

double  -> 8 byte -> 64 bit -> 15 ta son gacha aniqlikda saqlay oladi.

decimal -> 16 byte -> 128 bit -> 28 ta son gaca aniqlikda saqlay oladi yani qabul qiladi.


Bular orasida bizga qulayroqi bu **decimal** hisoblanadi yani osonroq.

Misol uchun : 1.5 + 2.3 = 3.8 qiymatini qaytaradi. 

**double** esa bunaqa oddiy odatdagidek korinishda bu ishni bajarmaydi yani 1.5 sonini ichkarida (1 + 1/2) kabi korinishda qoshib hisoblab beradi. tepadagi misolni javobini ham bizga oddiygina 3.8 chiqarib bermaydi 3.854515151 manashunaqa qoldiqlar bilan hisoblab beradi. SHUNING UCHUN HAM DOUBLE PUL HISOB KITOBLAR BILAN ISHLANADIGAN DASTURLARDA IMKON BORICHA ISHLATILINMAYDI!!!!

