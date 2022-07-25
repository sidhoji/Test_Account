using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Account;


namespace Test_Bank
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Account [] acc = new Account[5];
             int choice = 0;
            string name;
            double amount;
            int var = 0;

            while (choice != 6 )
            {
                Console.WriteLine(" 1: open account ");
                Console.WriteLine(" 2: deposit ");
                Console.WriteLine(" 3: withdraw ");
                Console.WriteLine(" 4: check balance ");
                Console.WriteLine(" 5: close account ");

                Console.WriteLine(" 6: exit ");
                Console.WriteLine("  Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("1. Savings : ");
                            Console.WriteLine("2. Current : ");
                            Console.WriteLine("3. Fixed : ");
                            int temp_choice = Convert.ToInt32(Console.ReadLine());
                            if (temp_choice == 1)
                            {
                                acc[var] = new Savings();                                
                            }
                            else if(temp_choice == 2)
                            {
                                acc[var] = new Current();
                            }
                            else if(temp_choice == 3)
                            {
                                acc[var] = new Fixed();
                            }

                            Console.WriteLine("enter name");
                            name = Console.ReadLine();
                            Console.WriteLine("enter amount ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            int acc_no = acc[var].open_acc(name, amount);
                            Console.WriteLine(" name : {0} account number = {1}",name, acc_no);
                            var++;                                                                                
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("enter account number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter deposit amount : ");
                        double temp_amount = Convert.ToDouble(Console.ReadLine());
                        for (int r = 0; r < 5; r++)

                        {
                            Account temp = acc[r];
                            if (temp.acc_num == num)
                            {
                                bool res = temp.deposit(temp_amount);
                                if (res == true)
                                {
                                    Console.WriteLine("The amount was successfully deposited");
                                    break;
                                }
                                else
                                    Console.WriteLine("failed");
                            }
                        }                  
                        break;
                    case 3:
                        Console.WriteLine("enter account number: ");
                         num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter withdraw amount : ");
                        temp_amount = Convert.ToDouble(Console.ReadLine());
                        for (int r = 0; r < 5; r++)
                        {
                            Account temp = acc[r];
                            if (temp.acc_num == num)
                            {
                                bool res = temp.Withdraw(temp_amount);
                                if (res==true)
                                {
                                    Console.WriteLine("The amount was successfully withdrawn");
                                    break;
                                }
                                else
                                    Console.WriteLine("failed");
                            }
                        }
                      
                        break;

                    case 4:
                        Console.WriteLine("enter account number: ");
                         num = Convert.ToInt32(Console.ReadLine());
                        for (int r = 0; r < 5; r++)
                        {
                            Account temp = acc[r];
                            if (temp.acc_num == num)
                            {
                                Console.WriteLine(" acc balance is {0}", acc[r].checkbalance);
                                break;
                            }
                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("enter account number: ");
                             num = Convert.ToInt32(Console.ReadLine());
                            for (int r = 0; r < 5; r++)
                            {
                                Account temp = acc[r];
                                if (temp.acc_num==num)
                                Console.WriteLine(acc[r].close_acc());
                            }
                                

                        }
                        break;

                }


                

            }
        }
    }
}
