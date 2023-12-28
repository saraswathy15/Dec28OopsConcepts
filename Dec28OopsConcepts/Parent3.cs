﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec28OopsConcepts
{
    public class Parent3
    {
        //static virtual void Fun333() { }
        //
        public virtual void SuperBazar() { Console.WriteLine("parent class super bazar"); }
        public void Fun1() { Console.WriteLine("parent class non vitrual method"); }
    }//end of parent 3    
    public class child3 : Parent3
    {
        public override void SuperBazar()
        {
            base.SuperBazar();//in case if we want call with base keyword
            Console.WriteLine("We are making it a MAll");
        }
        public new void Fun1() { Console.WriteLine("shadowing of parent fun signature"); }
        static void Main(string[] args)
        {
            child3 c3 = new child3(); c3.SuperBazar(); c3.Fun1();
        }
    }
}