using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Student:Person
    {
        public int IQRank;
        public int LanguageRank;

        public Student(string name , string surname , int age , int IQRank , int LanguageRank):base(name , surname , age)
        {
            this.IQRank = IQRank;
            this.LanguageRank = LanguageRank;
        }

        public void Examresult()
        {
            if (IQRank + LanguageRank < 120)
            {
                Console.WriteLine($"{name} {surname} sinifde qaldi!!! Bali : {IQRank + LanguageRank}");
            }
            else
            {
                Console.WriteLine($"{name} {surname} kecdi! Bali : {IQRank + LanguageRank}");
            }
        }
    }
}
