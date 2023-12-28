using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec28OopsConcepts
{// private variable is encapusalated and can not be directly access outside class
    public class BankAcc
    {
        private decimal bal;
        public decimal Balance
        {
            get { return bal; }//no set block
        }    //property
        public BankAcc(decimal intialBalance)
        {
            if (intialBalance <= 0) { throw new ArgumentOutOfRangeException("Initial balnce can not be  0"); }
            bal = intialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("deposite amout can not be zero");
            }
            bal += amount;
        }
        public void WithDraw(decimal amount)
        {
            if (amount <= 0) { throw new ArgumentException("please eneter amount above 0"); }
            bal -= amount;
        }
    }//end of bank class
    public class TestingBank
    {
        static void Main(string[] args)
        {
            BankAcc ba = new BankAcc(1000);// deposit some amout
            ba.Deposit(500);
            Console.WriteLine("after deposit 1000+500  " + ba.Balance);
            // withdraw  some amout
            ba.WithDraw(-1);
            Console.WriteLine("after withdraw   balnce " + ba.Balance);
            Console.ReadLine();
        }

    }
}
