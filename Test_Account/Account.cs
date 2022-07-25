using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Account
{
    public abstract class Account
    {
        protected string name;
        protected int acc_no;
        protected double balance;
        protected static int counter=0;
        protected double amount;

        public double checkbalance
        {
            get

            {
                return this.balance;
            } 
        }
        public string  close_acc()
        {
            return " Account has been sucessfully closed. ";

        }
       public virtual bool deposit(double amount )
        {   if (amount > 0)
            {
                balance = +amount;
                return true;
            }
            else
                return false;
          
            
        }
        public abstract int open_acc(string n, double amount);
        public abstract bool Withdraw(double amount);
        public int acc_num 
        {
            get
            {
                return acc_no;
            }
        }
        



         
    }
}
