﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DependencyInjectionCsharp
{
    class programm
    {
        public interface IAccount
        {
            void PrintDetails();
        }
        class CurrentAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine ("Detail Of CurrentAccount---");
            }
        }
        class SavingAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details Of SavingAccount");
            }
        }
            class Account
            {
                private IAccount account;

                public Account(IAccount account)//Parameterized Constructor
                {
                    this.account = account;
                }
                public void PrintDetails()
                {
                    account.PrintDetails();
                }
            }
         

        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
             Account a = new Account(ca);
            a.PrintDetails();

            IAccount sa =new SavingAccount();
            Account a2 =new Account(sa);
            a2.PrintDetails();

            Console .ReadLine();
        }
    }
}
