namespace KESCHA.Classes
{
    class Animal
    {
        public int age;
        // int age1;
        public int Age;
        public int Aage;

        public string Name;

        public int ageDifference;
        
        public Animal()
        {
            Name = "Noname";
            Age = 36;
            Aage=0;
        }
         public Animal(string name, int UserAge, int AnimalAge)
        {
            Name=name;
            Age = UserAge;
            Aage = AnimalAge;
            ageDifference=Age-Aage;
        }
        public void AboutmyFriends(string friendsName)
        {
            string[] a = new string [3];
            a[0]="Ali";
            a[1]="Vali";
            a[2]="Josh";
            System.Console.WriteLine($"{friendsName}ning {a[0]}, {a[1]} va {a[2]} ismli do'stlari bor");
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