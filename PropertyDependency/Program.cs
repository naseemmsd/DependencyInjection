using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDependency
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
                Console.WriteLine("Detail Of CurrentAccount---");
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
            public IAccount account { get; set; }
            public void PrintAcconts()
            {
                account.PrintDetails();
            }



            static void Main(string[] args)
            {
                Account sa = new Account();
                sa.account = new CurrentAccount();
                sa.PrintAcconts();

                Account ca = new Account();
                ca.account = new SavingAccount();
                ca.PrintAcconts();


                Console.ReadLine();
            }

        }
    }
}
