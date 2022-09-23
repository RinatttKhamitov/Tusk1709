using System;

namespace ДЗ_1709
{
    struct Student
    {
        public string date;
        public string firstName;
        public string secondName;
        public string alcotest;
        public double alcohol_drink;
        public Student(string date, string firstName, string secondName, string alcotest, double alcohol_drink)
        {
            this.date = date;
            this.firstName = firstName;
            this.secondName = secondName;
            this.alcotest = alcotest;
            this.alcohol_drink = alcohol_drink;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {firstName}, Возраст: {date}, категория алкоголизма: {alcotest}, объем выпитого алкоголя: {alcohol_drink}");
        }
    }
    struct Data
    {
        public string name;
        public string sity;
        public int age;
        public string PIN_Code;
        public Data(string name, string sity, int age, string PIN_Code)
        {
            this.name = name;
            this.sity = sity;
            this.age = age;
            this.PIN_Code = PIN_Code;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Город: {sity}, Возраст: {age}, PIN-код: {PIN_Code}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ДЗ задача номер 1
            Console.WriteLine("ДЗ задача номер 1");
            Student person = new Student();
            person.date = "10.11.2004";
            person.firstName = "Петя";
            person.alcotest = "d";
            person.alcohol_drink = 0;
            person.Print();

            Student person2 = new Student();
            person2.date = "16.11.2003";
            person2.firstName = "Вася";
            person2.alcotest = "b";
            person2.alcohol_drink = 4;
            person2.Print();

            Student person3 = new Student();
            person3.date = "6.3.2004";
            person3.firstName = "Влад";
            person3.alcotest = "с";
            person3.alcohol_drink = 2;
            person3.Print();

            Student person4 = new Student();
            person4.date = "24.8.2004";
            person4.firstName = "Коля";
            person4.alcotest = "a";
            person4.alcohol_drink = 8;
            person4.Print();

            Student person5 = new Student();
            person5.date = "24.7.2004";
            person5.firstName = "Степан";
            person5.alcotest = "d";
            person5.alcohol_drink = 0;
            person5.Print();

            double sum_alcohol = person.alcohol_drink + person2.alcohol_drink + person3.alcohol_drink + person4.alcohol_drink + person5.alcohol_drink;
            double alcohol_percentage = (person.alcohol_drink / sum_alcohol) * 100;
            double alcohol_percentage2 = (person2.alcohol_drink / sum_alcohol) * 100;
            double alcohol_percentage3 = (person3.alcohol_drink / sum_alcohol) * 100;
            double alcohol_percentage4 = (person4.alcohol_drink / sum_alcohol) * 100;
            double alcohol_percentage5 = (person5.alcohol_drink / sum_alcohol) * 100;
            Console.WriteLine($"1 студент выпил {(int)alcohol_percentage}%, 2 студент выпил {(int)alcohol_percentage2}%, 3 студент выпил {(int)alcohol_percentage3}%, 4 студент выпил {(int)alcohol_percentage4}%, 5 студент выпил {(int)alcohol_percentage5}%");

            Console.ReadKey();

            //ДЗ задача номер 2
            Console.WriteLine("");
            Console.WriteLine("ДЗ задача номер 2");
            Console.WriteLine("bool: хранит значение true или false (логические литералы) и занимает 1 байт");
            // Число
            Console.WriteLine("byte: хранит целое число от 0 до 255 и занимает 1 байт");
            Console.WriteLine("sbyte: хранит целое число от -128 до 127 и занимает 1 байт");
            Console.WriteLine("short: хранит целое число от -32768 до 32767 и занимает 2 байта");
            Console.WriteLine("int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта");
            Console.WriteLine("uint: хранит целое число от 0 до 4294967295 и занимает 4 байта");
            Console.WriteLine("long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт");
            Console.WriteLine("ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт");
            Console.WriteLine("float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта");
            Console.WriteLine("double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта");
            Console.WriteLine("decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение" +
                " от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт");
            // Строка
            Console.WriteLine("char: хранит одиночный символ в кодировке Unicode и занимает 2 байта");
            Console.WriteLine("string: хранит набор символов Unicode");
            Console.WriteLine("object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе");
            Console.ReadKey();

            //ДЗ задача номер 3
            Console.WriteLine("");
            Console.WriteLine("ДЗ задача номер 3");
            Console.WriteLine("Введи через пробел имя, город, возраст и PIN-код");
            string data = Console.ReadLine();
            string[] information = data.Split(' ');
            Data personData = new Data();
            personData.name = information[0];
            personData.sity = information[1];
            personData.age = int.Parse(information[2]);
            personData.PIN_Code = information[3];
            personData.Print();
            Console.ReadKey();

            //ДЗ задача номер 4
            Console.WriteLine("");
            Console.WriteLine("ДЗ задача номер 4");
            Console.WriteLine("Введи два слова");
            string text = Console.ReadLine(); 
            string[] slova = text.Split(' ');
            Console.WriteLine($"{slova[0][0]} {slova[1][0]}");
            Console.ReadKey();

            //ДЗ задача номер 5
            Console.WriteLine("");
            Console.WriteLine("ДЗ задача номер 5");
            Console.Write("Рыночная цена виски: ");
            int normPrice = int.Parse(Console.ReadLine()); // 10
            Console.Write("скидка в производстве %: ");
            int salePrice = 100 - int.Parse(Console.ReadLine()); // 10
            Console.Write("стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine()); // 500
            int income = normPrice - (normPrice * salePrice) / 100;
            int amount = holidayPrice / income;
            Console.WriteLine($"Вам нужно купить {amount} бутылок виски");
            Console.ReadKey();

            //ДЗ задача номер 6
            Console.WriteLine("");
            Console.WriteLine("ДЗ задача номер 6");
            double Speed(double speed)
            {

                return (speed * 100000) / 3600;
            }
            Console.Write("Какая скорость у таракна?(в км/ч): ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Скорость таракана в м/с = {(int)Speed(speed)}");
            Console.ReadKey();


            //ДЗ задача номер 7
            Console.WriteLine("");
            Console.WriteLine("ДЗ задача номер 7");
            Console.WriteLine("Введите строку");
            string textt = Console.ReadLine();
            string newtext = "";
            for (int i = 0; i < textt.Length; i++)
                if (textt[i] != textt.ToUpper()[i])
                    newtext += textt.ToUpper()[i];
                else
                {
                    newtext += textt.ToLower()[i];
                }
            Console.WriteLine(newtext);



        }
    }
}
