using KESCHA.Classes;
// int sonlar = 10000;
// // short sonlarcha = 100;
// // long sonlarr = 10000000;
// Console.Write("Ismingizni kiriting: ");
// string a=Console.ReadLine();
// Console.WriteLine("Sizning ismingiz "+a+" bo\'lsa kerak!");
// Console.WriteLine("Size of int is " + sizeof(int));
// Console.WriteLine($"The size of short is {sizeof(short)}");
// Console.WriteLine($"The size of int is {sizeof(int)}");
// Console.WriteLine($"The size of long is {sizeof(long)}");
// Console.WriteLine($"The min value of short is {short.MinValue}");
// Console.WriteLine($"The max value of short is {short.MaxValue}");
// Console.WriteLine($"The min value of int is {int.MinValue}");
// Console.WriteLine($"The maxvalue of int is {int.MaxValue}");
// Console.WriteLine($"The minvalue of long is {long.MinValue}");
// Console.WriteLine($"The maxvalue of long is {long.MaxValue}");
// Console.WriteLine($"The size of ushort is {sizeof(ushort)}");
// Console.WriteLine($"The size of uint is {sizeof(uint)}");
// Console.WriteLine($"The size of ulong is {sizeof(ulong)}");
// Console.WriteLine($"The min value of ushort is {ushort.MinValue}");
// Console.WriteLine($"The max value of ushort is {ushort.MaxValue}");
// Console.WriteLine($"The min value of uint is {uint.MinValue}");
// Console.WriteLine($"The maxvalue of uint is {uint.MaxValue}");
// Console.WriteLine($"The minvalue of ulong is {ulong.MinValue}");
// Console.WriteLine($"The maxvalue of ulong is {ulong.MaxValue}");
// Console.ReadKey();

// bool isGirl=true;
// bool isBoy=true;
// float fl=3.14f;
// double db=3.14;
// decimal dc=3.14m;
// decimal asn=dc+10;
// Console.WriteLine(asn);

//new casting

// int a=10;
// int b=a;
// int s=999999;
// short d=10;
// int e=d;
// long r=e;
// System.Console.WriteLine(r);

//converting
System.Console.Write("Enter your age: ");
int age=int.Parse(System.Console.ReadLine());
Animal kescha=new Animal(name:"Tatti", UserAge: age);
kescha.Age=4;
kescha.Age1=10;
// string a = kescha.Name;
System.Console.WriteLine(kescha.Name);
// Console.WriteLine($"Succesfully converted. Converted string was " + age);
// Console.Write("Enter his age: ");
// string hisAge = Console.ReadLine();
// int HisAge = Convert.ToInt32(hisAge);
// int ageDifference= age - kescha.Age;
Console.WriteLine($"Difference between with your and his age is: " + (kescha.ageDifference));
Console.WriteLine($"Is age difference bigger than HisAge: {kescha.ageDifference>=kescha.Age1}");
System.Console.WriteLine("------------------------------------");

// car spark = new car();
// spark.Year=1996;
// System.Console.WriteLine("===================");
// System.Console.Write("Type first number: ");
// string first = System.Console.ReadLine();
// int ifirst=Convert.ToInt32(first);
// // System.Console.Write("Type second number: ");
// // string second = System.Console.ReadLine();
// // int isecond=Convert.ToInt32(second);
// System.Console.WriteLine($"Is first number bigger than second: {ifirst>spark.Year}");
// System.Console.WriteLine($"Is first number smaller than second: {ifirst<spark.Year}");
// System.Console.WriteLine($"Is first number bigger or equal to second: {ifirst>=spark.Year}");
// System.Console.WriteLine($"Is first number smaller or equal to second: {ifirst<=spark.Year}");
// System.Console.WriteLine($"Is first number equal second: {ifirst==spark.Year}");
// System.Console.WriteLine($"Is first number not equal to second: {ifirst!=spark.Year}");
// System.Console.WriteLine("=========================");
