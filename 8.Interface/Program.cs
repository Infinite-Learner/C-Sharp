using System;
namespace CS8
{
    public interface Props
    {
        public void Get_Data(string Name, string Gender);
    }
    public class InterfaceImp : Props
    {
        string Name = "", Gender = "";
        public void Get_Data(string Name, string Gender)
        {
            this.Name = Name;
            this.Gender = Gender;
        }
        public void Display()
        {
            if (this.Gender.ToLower() == "male" || this.Gender.ToLower()=="m")
            {
                Console.WriteLine("Welcome Mr.{0}",this.Name);
                return;

            }
            Console.WriteLine("Welcome Miss.{0}", this.Name);
        }
       
    }
    public class Interface
    {
        public static void Main(string[] args)
        {
            string Name ="", Gender="";
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Gender : ");
            Gender = Console.ReadLine();
            InterfaceImp II = new InterfaceImp();
            II.Get_Data(Name, Gender);
            II.Display();

        }
    }

}