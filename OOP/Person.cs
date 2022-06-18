using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Pol { Мужской, Женский}
    public class Person
    {
        private string? fio;
        private int age;
        private double weight;
        private Pol pol;

        public Person(string? fio, int age, double weight, Pol pol)
        {
            this.Fio = fio;
            this.Age = age;
            this.weight = weight;
            this.pol = pol;
        }

        public string? Fio 
        {
            get { return fio; } 
            set 
            {
                if (value.Length >= 6 && value.Length <= 40)
                    fio = value;
            }
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                if(value>=0&&value<=150)
                    age = value;
            }
        }

        public double Weight
        {
            get { return weight; } 
            set 
            { 
                if(value>=0&&value<=200) weight = value; 
            }
        }
        public override string? ToString()
        {
            return $"ФИО:{fio}\nВозраст:{age}\n" +
                $"Вес:{weight:F2}\nПол:{pol}";
        }
        public void Go(int n)
        {
            int time = 0;
            do
            {
                time++;
                if(time%12==0) Age++;
                Console.WriteLine(this.ToString());
                Thread.Sleep(1000);
            }
            while (age <= n);
        }
    }
}
