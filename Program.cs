// 1. String tipida (string str) qiymat berilgan. Consoleda int tipidagi qiymat kiriting. 
// Agar bu son str ning uzunligidan katta bo’lsa, str ni katta harflarga o’giring, aks holda kichik harflarga o’giring.
// Input: x=13, str=”teLefOn”
// Output: “TELEFON”

System.Console.WriteLine("Int tipida son kiriting: ");
int son=Convert.ToInt32(System.Console.ReadLine());
string qiymat="SalomiddiN";
System.Console.WriteLine(qiymat.Length);
if(son>qiymat.Length)
    {
        System.Console.WriteLine(qiymat.ToUpper());
    }
else
    {
        System.Console.WriteLine(qiymat.ToLower());   
    }

// 2.
int x=15;
int y=10;
if(x>y)
    {
        System.Console.WriteLine("x is greater than y");
    }
else if (x<y)
    {
        System.Console.WriteLine("x is less than y");
    }
else if(x==y)
    {
        System.Console.WriteLine("x is equal to y");
    }
else
    {
        System.Console.WriteLine("x and y are not comparable");
    }

// 3.
System.Console.WriteLine("Hafta kunlarini kiriting: ");
string haf_kunlari=System.Console.ReadLine();
string result=haf_kunlari.ToLower() switch 
{
    "dushanba"=>$"Dushanba kunining tarjimasi Monday", 
    "seshanba"=>$"Dushanba kunining tarjimasi Monday", 
    "chorshanba"=>$"Dushanba kunining tarjimasi Monday", 
    "payshnba"=>$"Dushanba kunining tarjimasi Monday", 
    "juma"=>$"Dushanba kunining tarjimasi Monday", 
    "shanba"=>$"Dushanba kunining tarjimasi Monday", 
    "yakshanba"=>$"Dushanba kunining tarjimasi Monday",
    _       => "Hafta kuni topilmadi"
};
System.Console.WriteLine(result);