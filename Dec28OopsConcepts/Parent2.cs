using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec28OopsConcepts
{
    public class Parent2
    {
        public Parent2()
        {
            Console.WriteLine("parent class no parameter constructor");
        }
        public Parent2(int x)
        {
            Console.WriteLine("parent class overloaded constructor " + x);
        }
        static Parent2() { Console.WriteLine("parent class static constructor"); }
    }//end of parent
    public class Child2 : Parent2
    {
        public Child2()
        {
            Console.WriteLine("child class no parameter constructor");
        }
        public Child2(int x) : base(100)//base(x)
        {
            Console.WriteLine("child class overloaded constructor " + x);
        }
        static Child2() { Console.WriteLine("child  class static constructor"); }
        static void Main(string[] args)
        {
            Child2 c1 = new Child2();
            Child2 c2 = new Child2(10);
            Console.ReadLine();
        }
    }
}

