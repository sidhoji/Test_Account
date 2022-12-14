using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Account
{
    public class Fixed : Account
    {
        double min_balance = 10000;
        DateTime open_date;
        DateTime maturity_date;
        int term = 3;
        public override int open_acc(string n, double amount)
        {
            open_date = DateTime.Now;
            maturity_date = open_date.AddYears(term);
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
            if (DateTime.Compare(DateTime.Now , maturity_date)>0)
            {
                balance = balance - amount;
                return true;

            }
            else return false;
        }

    }

}
