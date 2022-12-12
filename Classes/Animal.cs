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

        private int agedifferencebetweenuserandanimal( int UserAge, int Age1)
        {
            return UserAge-Age1;
        }
    }
}