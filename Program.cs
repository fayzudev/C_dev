using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

System.Console.WriteLine("Program about a beauty parrot named KESCHA!!!");
System.Console.WriteLine();
System.Console.WriteLine();

// System.Console.WriteLine("Enter your name: ");
// string UserName = System.Console.ReadLine();
// System.Console.WriteLine($"Enter {UserName}'s age: ");
// double UserAge = double.Parse(System.Console.ReadLine());
// System.Console.WriteLine($"Enter {UserName}'s friend name: ");
// string friendsName = System.Console.ReadLine();
// System.Console.WriteLine("Enter your friends name: ");
// int friendsage=int.Parse(System.Console.ReadLine());
// if (UserAge>friendsage)
// {
//     System.Console.WriteLine($"{UserName} is older than his friend");
// }
// else
// {
//     System.Console.WriteLine($"{UserName} is younger than his friend");
// }
// System.Console.WriteLine($"{UserName} is {UserAge} years old");
// System.Console.WriteLine($"AgeDifference is {UserAge} - {friendsage} = {UserAge-friendsage}");

// if(UserName=="")
//     {
//         System.Console.WriteLine("Unknown person");
//     }
// else
// {
//     System.Console.WriteLine($"Salom {UserName}");
// }
// public virtual void greeting2(string UserName)
//         {
//             if(UserName=="")
//             {
//                 System.Console.WriteLine("Unknown person");
//             }
//             System.Console.WriteLine($"Salom {UserName}");
//         }


//         public abstract void greeting3(string UserName);
            // string [] a=new string[3];
            // a[0]="Ali";
            // a[1]="Vali";
            // a[2]="Josh";
            // System.Console.WriteLine($"{friendsName}ning {a[0]}, {a[1]} va {a[2]} ismli do'stlari bor");    
//         public void AboutmyFriends(string friendsName)
//         {
//             string[] a = new string [3];
//             a[0]="Ali";
//             a[1]="Vali";
//             a[2]="Josh";
//             Console.WriteLine($"{friendsName}ning {a[0]}, {a[1]} va {a[2]} ismli do'stlari bor");
//         }

            // System.Console.WriteLine(UserAge);
            // System.Console.WriteLine(friendsage);
            // if(UserAge==friendsage)
            //     {
            //         System.Console.WriteLine($"Age of {UserName} is equal to age fo {friendsName}");
            //     }
            // else if (UserAge>friendsage)
            //     {
            //         System.Console.WriteLine($"Age of {UserAge}is bigger than age of {friendsName}");
            //     }
            // else
            //     {
            //         System.Console.WriteLine($"Age of {UserAge}is less than age of {friendsName}");
            //     }
            
            // System.Console.Write("Enter your answer for marriage: ");
            // string answer=System.Console.ReadLine();
            // do
            //     {
            //         System.Console.WriteLine($"{UserName} ro'zi bo'magunizcha dastur tugamiydi");
            //     }
            // while(answer=="roziman");
                
            // if (answer=="roziman"){
            //     System.Console.WriteLine($"{UserName} turmushga chqishga rozi, to'y bo'ladi");
            // }
            // else if (answer=="ro'zimasman")
            // {
            //     System.Console.WriteLine($"{UserName} turmushga chiqishga rozi emas, to'y bo'miydi");
            // }
            // else System.Console.WriteLine("Javobni aytish kerak vaqt cho'zmasdan, baribir uydagilariz o'zizga tashlab qo'yishadi");

//         public void usingifelse()
//         {
//             Console.WriteLine(Age);
//             Console.WriteLine(AnAge);
//             if (Age==AnAge)
//             {
//                 Console.WriteLine($"Age of 1 person {Age} is equal to age of second person {AnAge}");
//             }
//             else if(Age>AnAge)
//             {
//                 Console.WriteLine($"Age of 1 person is bigger than age of second person!");
//             }

//             else
//             {
//                 Console.WriteLine($"Age of second person is bigger than age of first person!");
//             }
//         }

//         public void usingstringmessage()
//         {
//             string message=
//                 Age>AnAge
//                 ? "Age of 1 person is bigger than age of second person!"
//                 : "Age of second person is bigger than age of first person!";
//                 Console.WriteLine(message);
//         }

//         public void usingswitch(int UserAge)
//         {
//             Console.Write("Choose one of the operations(+,-,*,/,%):");
//             string operation=Console.ReadLine();
//             switch(operation)
//             {
//                 case "+":
//                     Console.WriteLine($"{UserAge} + {AnAge} = {UserAge+AnAge}");
//                     break;

//                 case "-":
//                     Console.WriteLine($"{UserAge} - {AnAge} = {UserAge-AnAge}");
//                     break;
//                 case "*":
//                     Console.WriteLine($"{UserAge} * {AnAge} = {UserAge*AnAge}");
//                     break;
//                 case "/":
//                     Console.WriteLine($"{UserAge} / {AnAge} = {UserAge/AnAge}");
//                     break;
//                 case "%":
//                     Console.WriteLine($"{UserAge} % {AnAge} = {UserAge%AnAge}");
//                     break;
//                 default:
//                         Console.WriteLine("Operation not found!");
//                     break;
//             }
//         }

//         public void usingresultswitch(int UserAge)
//         {
//             Console.Write("Choose one of the operations(+,-,*,/,%):");
//             string operation=Console.ReadLine();
//             string result = operation switch
//             {
//                 "+" => $"{UserAge} + {AnAge} = {UserAge+AnAge}",
//                 "-" => $"{UserAge} - {AnAge} = {UserAge-AnAge}",
//                 "*" => $"{UserAge} * {AnAge} = {UserAge*AnAge}",
//                 "/" => $"{UserAge} / {AnAge} = {UserAge/AnAge}",
//                 "%" => $"{UserAge} % {AnAge} = {UserAge%AnAge}",
//                 _  => "Operation not found!"
//             };
//             Console.WriteLine(result);
//         }
       
//         private int agedifferencebetweenuserandanimal( int UserAge, int Age1)
//         {
//             return UserAge-Age1;
//         }
//     }
// }

/////////////////////////////////////////
// System.Console.WriteLine("Program about CALCULATOR!!!");
// System.Console.WriteLine("--------------");
// System.Console.WriteLine("Enter first number: ");
// int firstNumber=int.Parse(System.Console.ReadLine());
// System.Console.WriteLine("Choose an operation(+,-,*,/,%): ");
// string operation = System.Console.ReadLine();
// System.Console.WriteLine("Enter second number: ");
// int secondNumber = Convert.ToInt32(System.Console.ReadLine());
// switch (operation)
//     {
//         case "+": 
//             System.Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
//             break;
//         case "-":
//             System.Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
//             break;
//         case "*":
//             System.Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
//             break;
//         case "/":
//             System.Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
//             break;
//         case "%":
//             System.Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
//             break;
//         default:
//             System.Console.WriteLine("Operation not found!");
//             break;
//     }

// string result = operation switch
//     {
//         "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
//         "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
//         "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
//         "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
//         "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
//         _   => "Operation not found!"
//     };
// System.Console.WriteLine(result);

///////////////////////////////

// while(firstNumber>10)
//     {
//         System.Console.WriteLine("It's done");
//     }

// string password="";
// do
//     {
//         System.Console.Write("Enter password: ");
//         password=System.Console.ReadLine();
        
//     }
// while(password != "12345678");

// string[] friendsName={"Ali", "Vli", "Nizom", "Joni"};
// int[] FriensAge={18,19,20,26};
// string[] FrAddress={"Andijan", "Namangan","Andijan","Fargona"};
// // System.Console.WriteLine($"{friendsName[0]} is {FriensAge[0]} years old and he is from {FrAddress[0]}");
// for(int i=0;i<=friendsName.Length-1;i++)
// {
//     System.Console.WriteLine($"{friendsName[i]} is {FriensAge[i]} years old and he is from {FrAddress[i]}");
// }

// System.Console.WriteLine("Necha xonalik karra jadvali hohlaysiz: ");
// int karra=Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine();
// for(int i=1;i<=10;i++)
// {
//     for(int j=1;j<=karra;j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }