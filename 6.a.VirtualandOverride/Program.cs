using System;
namespace CS5A
{
    public class Virtual
    {
        int a, b;
        public virtual void getValue()
        {
            Console.WriteLine("Base Class Method is Invoked...");
            Console.Write("Enter Value of a : ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Value of b : ");
            b = Int32.Parse(Console.ReadLine());
        }
        public virtual void disp()
        {
            Console.WriteLine("Base Class Data Members are a = {0} , b = {1}.", a, b);
        }
    }
    public class VirtualExt : Virtual
    {
        int a, b;
        public override void getValue()
        {
            Console.WriteLine("Derive Class Method is Invoked...");
            Console.Write("Enter Value of a : ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Value of b : ");
            b = Int32.Parse(Console.ReadLine());
        }
        public override void disp()
        {
            Console.WriteLine("Derive Class Data Members are a = {0} , b = {1}.", a, b);
        }
    }
    public class VirtualOverride
    {
        public static void Main()
        {
            Virtual obj = new Virtual();
            obj.getValue();
            obj.disp();
            //Overriding Derive class method and Base class is Overriden.
            obj = new VirtualExt();
            obj.getValue();
            obj.disp();
        }
    }
}