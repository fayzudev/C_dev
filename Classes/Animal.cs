namespace KESCHA.Classes
{
    class Animal
    {
        public int age;
        // int age1;
        public int Age;
        public int Age1;

        public string Name;

        public int ageDifference;
        
        public Animal()
        {
            Name = "Noname";
            Age = 36;
            Age1=0;
        }
         public Animal(string name, int UserAge)
        {
            Name=name;
            Age = UserAge;
            Age1 = 10;
            ageDifference=Age-Age1;
        }
        public void AboutmyFriends(string friendsName)
        {
            string[] a = new string [3];
            a[0]="Ali";
            a[1]="Vali";
            a[2]="Josh";
            System.Console.WriteLine($"{friendsName}ning {a[0]}, {a[1]} va {a[2]} ismli do'stlari bor");
        }
        private int agedifferencebetweenuserandanimal( int UserAge, int Age1)
        {
            return UserAge-Age1;
        }
    }
}