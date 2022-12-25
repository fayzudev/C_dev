using KESCHA.Classes;
Animal kescha=new Animal();
//converting
System.Console.Write("Enter your name: ");
string UserName = System.Console.ReadLine();
System.Console.Write("Enter your age: ");
int UserAge=int.Parse(System.Console.ReadLine());
System.Console.Write("Enter animal age: ");
int AnimaAge=int.Parse(System.Console.ReadLine());
kescha.greeting(UserName,UserAge,AnimaAge);

// System.Console.WriteLine($"Salom {kescha.Name}, ishlaring qalay");

// Console.WriteLine($"Succesfully converted. Converted string was " + age);
// Console.Write("Enter his age: ");
// string hisAge = Console.ReadLine();
// int HisAge = Convert.ToInt32(hisAge);
// int ageDifference= age - kescha.Age;
// Console.WriteLine($"Difference between with your and animal age is: " + (kescha.ageDifference));
// Console.WriteLine($"Is age difference bigger than {kescha.AnAge}: {kescha.ageDifference>=kescha.AnAge}");
// System.Console.WriteLine("------------------------------------");


System.Console.WriteLine("Tell me about your friends!");
kescha.AboutmyFriends(friendsName: UserName);
System.Console.WriteLine("------");
// string[] a = new string [3];
// a[0]="Ali";
// a[1]="Vali";
// a[2]="Josh";
// System.Console.WriteLine($"{a[0]}ning {a[1]} va {a[2]} ismli do'stlari bor");
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

// if (kescha.Age==kescha.AnAge)
// {
//     System.Console.WriteLine($"Age of 1 person {kescha.Age} is equal to age of second person {kescha.AnAge}");
// }
// else if(kescha.Age>kescha.AnAge)
// {
//     System.Console.WriteLine($"Age of 1 person is bigger than age of second person!");
// }
// else
// {
//     System.Console.WriteLine($"Age of second person is bigger than age of first person!");
// }

kescha.usingifelse();
System.Console.WriteLine("------");

// string message=
//     kescha.Age>kescha.AnAge
//         ? "Age of 1 person is bigger than age of second person!"
//         : "Age of second person is bigger than age of first person!";
// System.Console.WriteLine(message);

kescha.usingstringmessage();
System.Console.WriteLine("------");

// System.Console.Write("Choose one of the operations(+,-,*,/,%):");
// string operation=System.Console.ReadLine();
// switch(operation)
// {
//     case "+":
//         System.Console.WriteLine($"{age} + {AnAge} = {age+AnAge}");
//         break;

//     case "-":
//         System.Console.WriteLine($"{age} - {AnAge} = {age-AnAge}");
//         break;
//     case "*":
//         System.Console.WriteLine($"{age} * {AnAge} = {age*AnAge}");
//         break;
//     case "/":
//         System.Console.WriteLine($"{age} / {AnAge} = {age/AnAge}");
//         break;
//     case "%":
//         System.Console.WriteLine($"{age} % {AnAge} = {age%AnAge}");
//         break;
//     default:
//             System.Console.WriteLine("Operation not found!");
//         break;
// }

kescha.usingswitch(UserAge);
System.Console.WriteLine("------");

// string result = operation switch
// {
//     "+" => $"{age} + {AnAge} = {age+AnAge}",
//     "-" => $"{age} - {AnAge} = {age-AnAge}",
//     "*" => $"{age} * {AnAge} = {age*AnAge}",
//     "/" => $"{age} / {AnAge} = {age/AnAge}",
//     "%" => $"{age} % {AnAge} = {age%AnAge}",
//     _  => "Operation not found!"
// };
// System.Console.WriteLine(result);

kescha.usingresultswitch(UserAge);