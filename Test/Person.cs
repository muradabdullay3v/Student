using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public Person(string name , string surname , int age)
        {
            if ( name == "" || surname == "" || name == " " || surname == " " || age<6 || age > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Verilen xarekteristikalarda sehve yol verilib");
            }
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
}
