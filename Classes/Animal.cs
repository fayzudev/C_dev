namespace KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {
        // public int age;
        // int age1;
        public int Age;
        public int AnAge;

        public string Name;

        public int ageDifference;
        public DateTimeOffset createdDate { get; set; }
        public Animal(string name, int UserAge, int AnimalAge)
        {
            Name=name;
            Age = UserAge;
            AnAge = AnimalAge;
            createdDate=DateTimeOffset.Now;
        }
        // public Animal()
        // {
        //     Name = "Noname";
        //     Age = 36;
        //     AnAge=0;
        // }
        public void greeting(string UserName, int UserAge, int AnimalAge)
        {
            Name=UserName;
            Age = UserAge;
            AnAge = AnimalAge;
            Console.WriteLine($"Salom {Name}, ishlaring qalay");
            createdDate=DateTimeOffset.Now;
        }
        public virtual void greeting2(string UserName)
        {
            if(UserName=="")
            {
                System.Console.WriteLine("Unknown person");
            }
            System.Console.WriteLine($"Salom {UserName}");
        }

        public abstract void greeting3(string UserName);
        
        public void AboutmyFriends(string friendsName)
        {
            string[] a = new string [3];
            a[0]="Ali";
            a[1]="Vali";
            a[2]="Josh";
            Console.WriteLine($"{friendsName}ning {a[0]}, {a[1]} va {a[2]} ismli do'stlari bor");
        }
        public void usingifelse()
        {
            Console.WriteLine(Age);
            Console.WriteLine(AnAge);
            if (Age==AnAge)
            {
                Console.WriteLine($"Age of 1 person {Age} is equal to age of second person {AnAge}");
            }
            else if(Age>AnAge)
            {
                Console.WriteLine($"Age of 1 person is bigger than age of second person!");
            }

            else
            {
                Console.WriteLine($"Age of second person is bigger than age of first person!");
            }
        }

        public void usingstringmessage()
        {
            string message=
                Age>AnAge
                ? "Age of 1 person is bigger than age of second person!"
                : "Age of second person is bigger than age of first person!";
                Console.WriteLine(message);
        }

        public void usingswitch(int UserAge)
        {
            Console.Write("Choose one of the operations(+,-,*,/,%):");
            string operation=Console.ReadLine();
            switch(operation)
            {
                case "+":
                    Console.WriteLine($"{UserAge} + {AnAge} = {UserAge+AnAge}");
                    break;

                case "-":
                    Console.WriteLine($"{UserAge} - {AnAge} = {UserAge-AnAge}");
                    break;
                case "*":
                    Console.WriteLine($"{UserAge} * {AnAge} = {UserAge*AnAge}");
                    break;
                case "/":
                    Console.WriteLine($"{UserAge} / {AnAge} = {UserAge/AnAge}");
                    break;
                case "%":
                    Console.WriteLine($"{UserAge} % {AnAge} = {UserAge%AnAge}");
                    break;
                default:
                        Console.WriteLine("Operation not found!");
                    break;
            }
        }

        public void usingresultswitch(int UserAge)
        {
            Console.Write("Choose one of the operations(+,-,*,/,%):");
            string operation=Console.ReadLine();
            string result = operation switch
            {
                "+" => $"{UserAge} + {AnAge} = {UserAge+AnAge}",
                "-" => $"{UserAge} - {AnAge} = {UserAge-AnAge}",
                "*" => $"{UserAge} * {AnAge} = {UserAge*AnAge}",
                "/" => $"{UserAge} / {AnAge} = {UserAge/AnAge}",
                "%" => $"{UserAge} % {AnAge} = {UserAge%AnAge}",
                _  => "Operation not found!"
            };
            Console.WriteLine(result);
        }
       
        private int agedifferencebetweenuserandanimal( int UserAge, int Age1)
        {
            return UserAge-Age1;
        }
    }
}