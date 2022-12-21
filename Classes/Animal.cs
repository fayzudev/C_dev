namespace KESCHA.Classes
{
    class Animal
    {
        public int age;
        // int age1;
        public int Age;
        public int AnAge;

        public string Name;

        public int ageDifference;
        
        public Animal()
        {
            Name = "Noname";
            Age = 36;
            AnAge=0;
        }
         public Animal(string name, int UserAge, int AnimalAge)
        {
            Name=name;
            Age = UserAge;
            AnAge = AnimalAge;
            ageDifference=Age-AnAge;
        }
        public void AboutmyFriends(string friendsName)
        {
            string[] a = new string [3];
            a[0]="Ali";
            a[1]="Vali";
            a[2]="Josh";
            System.Console.WriteLine($"{friendsName}ning {a[0]}, {a[1]} va {a[2]} ismli do'stlari bor");
        }
        public void usingifelse()
        {
            System.Console.WriteLine(Age);
            System.Console.WriteLine(AnAge);
            if (Age==AnAge)
            {
                System.Console.WriteLine($"Age of 1 person {Age} is equal to age of second person {AnAge}");
            }
            else if(Age>AnAge)
            {
                System.Console.WriteLine($"Age of 1 person is bigger than age of second person!");
            }

            else
            {
                System.Console.WriteLine($"Age of second person is bigger than age of first person!");
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
        public void greeting()
        {
            System.Console.WriteLine($"Salom {Name}, ishlaring qalay");
        }
        private int agedifferencebetweenuserandanimal( int UserAge, int Age1)
        {
            return UserAge-Age1;
        }
    }
}