using KESCHA.Enums;
namespace KESCHA.Classes

{
    public class Pet : Animal
    {
        public PetType Type{ get; set; }
        public Pet(string name, int UserAge, int AnimalAge)
            :base(name, UserAge, AnimalAge)
            {

            }
        public override void greeting2(string UserName)
        {
            System.Console.WriteLine($"Meow {UserName}");
        }

        public override void greeting3(string UserName)
        {
            System.Console.WriteLine("Abs");
        }
    }
}