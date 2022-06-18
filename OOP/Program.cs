// See https://aka.ms/new-console-template for more information

using OOP;

//Person person1 = new Person("Иванов Иван", 20,
//    65.67, Pol.Мужской);
//Console.WriteLine(person1.ToString());
//person1.Go(22);

Student student = new Student("Иванов","Иван","Иванович",
                                18,"19-CА-4");
Console.WriteLine(student.ToString());
Console.WriteLine("Выберите предмет:\n1-Программирование\n" +
    "2-Администрирование\n3-Дизайн");
int n=int.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        student.addMark("Программирование");
        break;
    case 2:
        student.addMark("Администрирование");
        break;
    case 3:
        student.addMark("Дизайн");
        break;
    default:
        Console.WriteLine("Такого предмета нет");
        break;
}
Console.WriteLine(student.ToString());
Console.WriteLine("Выберите предмет для подсчета среднего арифметического:\n1-Программирование\n" +
    "2-Администрирование\n3-Дизайн");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Средний балл:"+student.AvgMarks(n));