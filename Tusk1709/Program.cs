using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk1709
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


    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ номер 1
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

            //ДЗ задача номер 7
            Console.WriteLine("");
            Console.WriteLine("ДЗ задача номер 7");
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            string newtext = "";
            for (int i = 0; i < text.Length; i++)
                if (text[i] != text.ToUpper()[i])
                    newtext += text.ToUpper()[i];
                else
                {
                    newtext += text.ToLower()[i];
                }
            Console.WriteLine(newtext);


        }
    }
}