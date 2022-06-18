using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        private string? firstName;
        private string? lastName;
        private string? middleName;
        private int age;
        private string group;
        List<List<int>> marks = new List<List<int>>();

        public Student(string? firstName, string? lastName, 
                            string? middleName, int age,string group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.age = age;
            this.group=group;
            marks.Add(new List<int>());
            marks.Add(new List<int>());
            marks.Add(new List<int>());
            for (int i=0;i<new Random().Next(1,10);i++)
            {
                marks[0].Add(new Random().Next(2,6));
            }
            for (int i = 0; i < new Random().Next(1, 10); i++)
            {
                marks[1].Add(new Random().Next(2, 6));
            }
            for (int i = 0; i < new Random().Next(1, 10); i++)
            {
                marks[2].Add(new Random().Next(2, 6));
            }
        }

        public override string? ToString()
        {
            string res= $"Фамилия:{firstName}\nИмя:{lastName}\n" +
                $"Отчество:{middleName}\nГруппа:{group}\n" +
                $"Возраст:{age}\nОценки:\nПрограммирование:\n";
            for (int i = 0; i < marks[0].Count; i++)
            {
                res += marks[0][i] + " ";
            }
            res += "\nАдминистрирование\n";
            for (int i = 0; i < marks[1].Count; i++)
            {
                res += marks[1][i] + " ";
            }
            res += "\nДизайн\n";
            for (int i = 0; i < marks[2].Count; i++)
            {
                res += marks[2][i] + " ";
            }
            res += "\n";
            return res;
        }
        public void addMark(string name)
        {
            int n;
            switch(name)
            {
                case "Программирование":
                    Console.WriteLine("Введите оценку:");
                    n = int.Parse(Console.ReadLine());
                    marks[0].Add(n);
                    break;
                case "Администрирование":
                    Console.WriteLine("Введите оценку:");
                    n = int.Parse(Console.ReadLine());
                    marks[1].Add(n);
                    break;
                case "Дизайн":
                    Console.WriteLine("Введите оценку:");
                    n = int.Parse(Console.ReadLine());
                    marks[2].Add(n);
                    break;

            }
        }
        public double AvgMarks(int n)
        {
            double sum = 0;
            for (int i = 0; i < marks[n-1].Count; i++)
            {
                sum+=marks[n-1][i];
            }
            return sum/marks[n-1].Count;
        }
    }
}
