using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencybyMethod
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
        public void PrintAccounts(IAccount account)
        {
            account.PrintDetails();

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.PrintAccounts(new SavingAccount());

            Account ca = new Account();
            ca.PrintAccounts(new CurrentAccount());
            ca.PrintAccounts(new CurrentAccount());

            Console.ReadLine();

        }

    }
}

