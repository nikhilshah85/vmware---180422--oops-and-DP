using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankingLIB;
namespace bankingSolutionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo 1 - Abstraction, encapsulation and Inheritance
            //    Accounts accObj = new Accounts(); 
            //    //this are all the set
            //    accObj.accNo = 101;
            //    accObj.accName = "Nikhil";
            //    accObj.accType = "Savings";
            //    accObj.accBalance = 8000;
            //    accObj.accIsActive = true;

            //    Savings savObj = new Savings();
            //    Current cur = new Current();
            //    PF pfObj = new PF();



            //    Console.WriteLine("Account Balance is " +accObj.accBalance);


            //    try
            //    {
            //        Console.WriteLine("Enter A Choice");
            //        Console.WriteLine("1. Widraw");
            //        Console.WriteLine("2. Deposit");
            //        int choice = Convert.ToInt32(Console.ReadLine());
            //        if (choice == 1)
            //        {
            //            accObj.Widraw(-2000);
            //        }
            //        else
            //        {
            //            accObj.Deposit(300);
            //        }
            //        Console.WriteLine("Thank you, balance after transaction is " + accObj.accBalance);
            //    }
            //    catch (Exception es)
            //    {
            //        Console.WriteLine(es.Message);
            //    }
            #endregion


            #region Demo 2 -  Polymprphic Behaviour
            //for the widraw method, we need a different behaviour for all the 3 accounts
            //Savings, max widraw 20K
            //current, max widraw 50k
            //Pf,      max widraw 30% of available bal



            //Savings sav = new Savings() { accBalance = 60000 };
            //Current cur = new Current() { accBalance = 60000 };
            //PF pf = new PF() { accBalance = 60000 };

            //try
            //{
            //    Console.WriteLine(pf.Widraw(30000));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            Loan acc = new Loan();
            acc.accBalance = 250000;
            Console.WriteLine(acc.Widraw(-30000));

        }
    }
}
