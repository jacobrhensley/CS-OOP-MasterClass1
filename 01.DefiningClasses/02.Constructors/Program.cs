using System;

namespace _02.Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account2 = new Account(10.00);
            Account account3 = new Account("A3", 20.00);
        }
    }
}


