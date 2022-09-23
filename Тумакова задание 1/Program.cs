using System;

namespace Тумакова_задание_1
{
    struct Bank_account
    {
        public string number;
        public string type;
        public string balance;
        public Bank_account(string number, string type, string balance)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
        }
        public void Print()
        {
            Console.WriteLine($"Номер: {number}, тип: {type}, баланс {balance}");
        }
    }
    struct Worker
    {
        enum university { КГУ, КАИ, КХТИ }
        public string name;
        public int number;

        public Worker(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public void Print()
        {
            Console.WriteLine($"ФИО: {name}, Вуз: {(university)number}");
        }
    }
    class Program
    {

        enum bank { current, savings }
        static void Main(string[] args)
        {
            Console.WriteLine("задание 3.1");
            foreach (bank credit in Enum.GetValues(typeof(bank)))
            {
                Console.WriteLine("Кредит: {0}, Номер: {1}", credit, (int)credit);

            }
            Console.ReadKey();
            Console.WriteLine("задание 3.2");
            Bank_account bank_a = new Bank_account();
            bank_a.number = "1432432423532532";
            bank_a.type = "Mir";
            bank_a.balance = "219380123 руб";
            bank_a.Print();

            Console.ReadKey();
            Console.WriteLine("Домашнее задание 3.1");

            Worker work = new Worker();
            work.name = "Вася Пупкин";
            work.number = 0;
            work.Print();

            Worker work2 = new Worker();
            work2.name = "Хамитов Ринат";
            work2.number = 1;
            work2.Print();

            Worker work3 = new Worker();
            work3.name = "Магомед Асханбаев";
            work3.number = 2;
            work3.Print();


        }
    }

}
