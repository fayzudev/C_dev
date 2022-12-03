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
         public Animal(string name,int UserAge, int AgeDifference)
        {
            Name=name;
            Age = UserAge;
            Age1 = 10;
            ageDifference=Age-Age1;
        }
    }
}