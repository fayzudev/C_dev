// // 1. String tipida (string str) qiymat berilgan. Consoleda int tipidagi qiymat kiriting. 
// // Agar bu son str ning uzunligidan katta bo’lsa, str ni katta harflarga o’giring, aks holda kichik harflarga o’giring.
// // Input: x=13, str=”teLefOn”
// // Output: “TELEFON”

// System.Console.WriteLine("Int tipida son kiriting: ");
// int son=Convert.ToInt32(System.Console.ReadLine());
// string qiymat="SalomiddiN";
// System.Console.WriteLine(qiymat.Length);
// if(son>qiymat.Length)
//     {
//         System.Console.WriteLine(qiymat.ToUpper());
//     }
// else
//     {
//         System.Console.WriteLine(qiymat.ToLower());   
//     }

// // 2.
// int x=15;
// int y=10;
// if(x>y)
//     {
//         System.Console.WriteLine("x is greater than y");
//     }
// else if (x<y)
//     {
//         System.Console.WriteLine("x is less than y");
//     }
// else if(x==y)
//     {
//         System.Console.WriteLine("x is equal to y");
//     }
// else
//     {
//         System.Console.WriteLine("x and y are not comparable");
//     }

// // 3.
// System.Console.WriteLine("Hafta kunlarini kiriting: ");
// string haf_kunlari=System.Console.ReadLine();
// string result=haf_kunlari.ToLower() switch 
// {
//     "dushanba"=>$"Dushanba kunining tarjimasi Monday", 
//     "seshanba"=>$"Dushanba kunining tarjimasi Monday", 
//     "chorshanba"=>$"Dushanba kunining tarjimasi Monday", 
//     "payshnba"=>$"Dushanba kunining tarjimasi Monday", 
//     "juma"=>$"Dushanba kunining tarjimasi Monday", 
//     "shanba"=>$"Dushanba kunining tarjimasi Monday", 
//     "yakshanba"=>$"Dushanba kunining tarjimasi Monday",
//     _       => "Hafta kuni topilmadi"
// };
// System.Console.WriteLine(result);

//Basics.Tanlash bo'limi uchun 2-amaliy vazifa
// 1.
// System.Console.WriteLine("Vaqt kiriting(soniyalarda hisoblanadi): ");
// int time=int.Parse(System.Console.ReadLine());
// int minute=time/60;
// System.Console.WriteLine($"{minute}:{time-minute*60}");

// // 2.
// System.Console.WriteLine("Enter your age: ");
// int age=Convert.ToInt32(System.Console.ReadLine());
// if(age>=0 && age<=12)
//     {
//         System.Console.WriteLine($"Your age is {age} and you are child");
//     }
// else if(age>12 && age<=19)
//     {
//         System.Console.WriteLine($"Your age is {age} and you are teenager");
//     }
// else if(age>19 && age<=59)
//     {
//         System.Console.WriteLine($"Your age is {age} and you are older");
//     }
// else System.Console.WriteLine($"Your age is {age} and you are senior");

// // 3.
// System.Console.WriteLine("Enter a ball from 1st subject: ");
// int first_subject=Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Enter a ball from 2nd subject: ");
// int second_subject=Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Enter a ball from 3rd subject: ");
// int third_subject=Convert.ToInt32(System.Console.ReadLine());
// int overall=(first_subject+second_subject+third_subject)/3;
// string result=
//     first_subject>100 || second_subject>100 || third_subject>100
//         ? "Mark can not be up to 100"
//         : overall>=80 && overall<=100
//             ? "Your mark is perfect"
//             : overall>=60 && overall<=79
//                 ? "Your mark is good"
//                 : overall >=40 && overall<=59
//                     ? "Your mark is acceptable"
//                     : "Your mark is unacceptable";

// System.Console.WriteLine(result);

// // 4.
// System.Console.WriteLine("Enter a number in your mind: ");
// int num=Convert.ToInt32(System.Console.ReadLine());
// Random rand=new Random();
// int tas=rand.Next(100);
// string res=
//     tas>=num
//     ? "A number in your mind is less than randomized number"
//     : "A number in your mind is bigger than randomized number";
// System.Console.WriteLine($"{res}. Number in your mind was {num}, randomized number is {tas}");

//Basics.Takrorlash.1
// 1.
// int son=1;
// int sum=0;
// while (son<=1000)
// {
//     if(son%2==1)
//     {
//     sum+=son;
//     }
//     son+=1;
// }
// System.Console.WriteLine(sum);

// 2.
// int[] arr1={10,5,8,69,3,5,9,44,56,96,25,325,33,45};

// int smallest=arr1[0];
// int biggest=arr1[0];
// for(int i=0;i<arr1.Length;i++)
// {
//     if(smallest>arr1[i])
//     {
//         smallest=arr1[i];
//     }
// }

// for(int i=0;i<arr1.Length;i++)
// {
//     if(biggest<arr1[i])
//     {
//         biggest=arr1[i];
//     }
// }

// System.Console.WriteLine
// ($"The multiplication of minimum and maximum numbers of array is {smallest} * {biggest} = {smallest*biggest}");

// 3.
// System.Console.WriteLine("Enter the value of factorial number: ");
// int value=int.Parse(System.Console.ReadLine());
// int factorial=1;
// for(int i=1;i<=value;i++)
// {
//     factorial*=i;
// }
// System.Console.WriteLine($"Factorial of the typed value is {factorial}");

Console.Write("Radiusni kiriting: ");
double r = double.Parse(Console.ReadLine());
double S = Math.PI * Math.Pow(r, 2);
double L = Math.PI * r * 2;
Console.WriteLine($"Doira yuzi S={S} va doira uzunligi L={L}");
Console.ReadKey();

Console.Write("Necha dollar almashtirmoqchisiz?: ");
int dollar = int.Parse(Console.ReadLine());
Console.WriteLine("Xozirgi kurs: 12400 so'm");
int qiymat = dollar * 12400;
Console.WriteLine($"Sizga {qiymat} so'm beriladi");


Console.Write("Tug'ilgan yilingizni kiriting: ");
int yosh=int.Parse(Console.ReadLine());
int kun = (2024 - yosh) * 365;
Console.WriteLine($"Siz {kun} kunlik bo'ldingiz!");

Console.WriteLine("1-raqamni kiriting: ");
int BirinchiSon = int.Parse(Console.ReadLine());
Console.WriteLine("Qanday amal bajarmoqchisiz(+,-,*,/,%): ");
string result = Console.ReadLine();
Console.WriteLine("2-raqamni kiriting:");
int IkkinchiSon = int.Parse(Console.ReadLine());
switch (result)
{
    case "+":
        Console.WriteLine($"{BirinchiSon}+{IkkinchiSon}={BirinchiSon + IkkinchiSon}");
        break;
    case "-":
        Console.WriteLine($"{BirinchiSon}-{IkkinchiSon}={BirinchiSon - IkkinchiSon}");
        break;
    case "*":
        Console.WriteLine($"{BirinchiSon}*{IkkinchiSon}={BirinchiSon * IkkinchiSon}");
        break;
    case "/":
        Console.WriteLine($"{BirinchiSon}/{IkkinchiSon}={BirinchiSon / IkkinchiSon}");
        break;
    case "%":
        Console.WriteLine($"{BirinchiSon}%{IkkinchiSon}={BirinchiSon % IkkinchiSon}");
        break;
    default:
        Console.WriteLine("There is no operation");
        break;
}

Console.WriteLine("Please enter the number: ");
int number=int.Parse(Console.ReadLine());
int Sum = 0;
int value = 1;
while (value <= number) 
    {
        Sum+=value;
        value++;
    }
Console.WriteLine($"Sum is {Sum}");
//------------------
Console.WriteLine("Please enter the number: ");
int number=Convert.ToInt32(Console.ReadLine());
if (number % 2==1)
    { Console.WriteLine("Number is odd"); }
else 
    { Console.WriteLine("Number is even"); }
//---------------
Console.Write("Biror son kiriting: ");
int son = int.Parse(Console.ReadLine());

if (son <= 1)
{
    Console.WriteLine("Tub emas");
}
else
{
    bool tub = true;

    for (int i = 2; i < son; i++)
    {
        if (son % i == 0)
        {
            tub = false;
            break;
        }
    }

    if (tub)
    {
        Console.WriteLine("Tub");
    }
    else
    {
        Console.WriteLine("Tub emas");
    }
}
//--------------
Console.Write("Enter the any number: ");
int num=int.Parse(Console.ReadLine());

for (int i = 2; i <= 10; i++) 
    {
    if (num % i == 0)
        {
        Console.Write($"Sonlar: {i} "); 
        }
    }
Console.WriteLine("-------------------------");
Console.Write("Son kiriting: ");
int son = int.Parse(Console.ReadLine());

bool tub = false;

Console.Write("Bo'luvchilari: ");
for (int i = 2; i <= 10; i++)
{
    if (son % i == 0)
    {
        if (tub)
        {
            Console.Write(", ");
        }
        Console.Write(i);
        tub = true;
    }
}

if (!tub)
{
    Console.WriteLine("yo'q.");
}