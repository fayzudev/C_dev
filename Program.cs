using KESCHA.Classes;
using KESCHA.Enums;

internal class Program
{
    static void Main()
    {
        try
        {
            Animal kescha = new Bird(name: "Kescha", UserAge: 26, AnimalAge: 10);
            Pet kasee = new Pet(name: "Kasee", UserAge: 26, AnimalAge: 2);
            System.Console.WriteLine("Program was created: " + kescha.createdDate);
            kasee.Type = PetType.Cat;
            System.Console.WriteLine(kasee.Type);
            //converting
            Console.Write("Enter your name: ");
            string UserName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter animal age: ");
            // int AnimalAge = int.Parse(Console.ReadLine());
            // kescha.greeting(UserName,UserAge,AnimalAge);
            // kasee.greeting(UserName,UserAge,AnimalAge);
            kescha.greeting2(UserName);
            kasee.greeting2(UserName);

            kescha.greeting3(UserName);
            kasee.greeting3(UserName);
            Console.WriteLine("Tell me about your friends!");

            kescha.AboutmyFriends(friendsName: UserName);
            Console.WriteLine("------");
            kescha.usingifelse();
            Console.WriteLine("------");
            kescha.usingstringmessage();
            Console.WriteLine("------");
            kescha.usingswitch(UserAge);
            Console.WriteLine("------");
            kescha.usingresultswitch(UserAge);
        }
        catch(FormatException formatexception)
        {
            System.Console.WriteLine($"Error was thrown. Message: {formatexception.Message}");
        }

        catch(Exception exception)
        {
            System.Console.WriteLine("Error was thrown. Unknown error");
        }
        
        System.Console.WriteLine("Program was ended!");
    }
}