using System;

namespace Тумакова_задание_1
{
    class Program
    {
        enum bank { current, savings }
        static void Main(string[] args)
        {
            bank bankAccount;
            bankAccount = bank.current;
            bank bankAccount2;
            bankAccount2 = bank.savings;

            Console.WriteLine($"{bankAccount}, {bankAccount2}");
        }
    }
    class Program1 
    {
        public struct Employee
        {
            public string firstName;
            public int age;
        }
    }

}
