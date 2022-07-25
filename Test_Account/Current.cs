using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Account
{
   public class Current: Account
    {
         double min_balance = 5000;
        double oda = 3000;

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
            if ((balance + oda) > amount)
            {
                balance = balance - amount;
                return true;

            }
            else return false;
        }

    }
}
