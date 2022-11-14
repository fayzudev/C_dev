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
Console.Write("Enter your name: ");
string a = Console.ReadLine();
Console.WriteLine($"Is your name {a}");
Console.Write("Enter your age: ");
string b = Console.ReadLine();
int age = Convert.ToInt32(b);
Console.WriteLine($"Succesfully converted. Converted string was " + age);
Console.Write("Enter his age: ");
string hisAge = Console.ReadLine();
int HisAge = Convert.ToInt32(hisAge);
Console.WriteLine($"Difference between with your and his age is: " + (age - HisAge));



