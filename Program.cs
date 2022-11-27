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

// //converting
Console.Write("Enter your name: ");
string a = Console.ReadLine();
Console.WriteLine($"What's goin' on {a}");
Console.Write("Enter your age: ");
string b = Console.ReadLine();
int b_age  = Convert.ToInt32(b);
// Console.WriteLine($"Succesfully converted. Converted string was " + b_age);
// System.Console.WriteLine("Enter operation(+,-,*,/,%): ");
// string operation= System.Console.ReadLine();
Console.Write("Enter his age: ");
string hisAge = Console.ReadLine();
int HisAge = Convert.ToInt32(hisAge);
// int ageDifference= b_age - HisAge;
// Console.WriteLine($"Difference between with your and his age is: " + (ageDifference));
// Console.WriteLine($"Is age difference bigger than HisAge: {ageDifference>=HisAge}");
System.Console.WriteLine("------------------------------------");

// System.Console.WriteLine("===================");
// System.Console.Write("Type first number: ");
// string first = System.Console.ReadLine();
// int ifirst=Convert.ToInt32(first);
// System.Console.Write("Type second number: ");
// string second = System.Console.ReadLine();
// int isecond=Convert.ToInt32(second);
// System.Console.WriteLine($"Is first number bigger than second: {ifirst>isecond}");
// System.Console.WriteLine($"Is first number smaller than second: {ifirst<isecond}");
// System.Console.WriteLine($"Is first number bigger or equal to second: {ifirst>=isecond}");
// System.Console.WriteLine($"Is first number smaller or equal to second: {ifirst<=isecond}");
// System.Console.WriteLine($"Is first number equal second: {ifirst==isecond}");
// System.Console.WriteLine($"Is first number not equal to second: {ifirst!=isecond}");
// System.Console.WriteLine("=========================");

// if (b_age==HisAge)
// {
//     System.Console.WriteLine($"Age of 1 person {b_age} is equal to age of second person {HisAge}");
// }
// else if(b_age>HisAge)
// {
//     System.Console.WriteLine($"Age of 1 person is bigger than age of second person!");
// }

// else
// {
//     System.Console.WriteLine($"Age of second person is bigger than age of first person!");
// }

// string message=
//     b_age>HisAge
//         ? "Age of 1 person is bigger than age of second person!"
//         : "Age of second person is bigger than age of first person!";
// System.Console.WriteLine(message);

// switch(operation)
// {
//     case "+":
//         System.Console.WriteLine($"{b_age} + {HisAge} = {b_age+HisAge}");
//         break;

//     case "-":
//         System.Console.WriteLine($"{b_age} - {HisAge} = {b_age-HisAge}");
//         break;
//     case "*":
//         System.Console.WriteLine($"{b_age} * {HisAge} = {b_age*HisAge}");
//         break;
//     case "/":
//         System.Console.WriteLine($"{b_age} / {HisAge} = {b_age/HisAge}");
//         break;
//     case "%":
//         System.Console.WriteLine($"{b_age} % {HisAge} = {b_age%HisAge}");
//         break;
//     default:
//             System.Console.WriteLine("Operation not found!");
//         break;
// }

// string result = operation switch
// {
//     "+" => $"{b_age} + {HisAge} = {b_age+HisAge}",
//     "-" => $"{b_age} - {HisAge} = {b_age-HisAge}",
//     "*" => $"{b_age} * {HisAge} = {b_age*HisAge}",
//     "/" => $"{b_age} / {HisAge} = {b_age/HisAge}",
//     "%" => $"{b_age} % {HisAge} = {b_age%HisAge}",
//     _  => "Operation not found!"
// };
// System.Console.WriteLine(result);

if (b_age>HisAge)
{
    int count=0;
    while(count<b_age)
    {
        System.Console.WriteLine(count);
        count++;
    }

}
else
{
    System.Console.WriteLine("404");
}