using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Account
{
    public class Savings : Account
    { double min_balance = 1000;
        double min_withdraw = 1000;

        public override int open_acc(string n, double amount)
        {
            if (amount > min_balance)
            {
                name = n;
                balance += amount;
                counter++;
                acc_no = counter;
                return acc_no;
                
            }
            else return 0;
            

        }
        public override bool Withdraw(double amount)
        {
            if ((balance-amount) > min_withdraw)
            {
                balance = balance - amount;
                return true;
                                 
            }
            else return false;
        }

        


    }
}
