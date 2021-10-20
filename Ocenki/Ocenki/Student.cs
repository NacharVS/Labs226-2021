using System;

namespace Ocenki
{
    class Student
    {
        public string Obshaga;
        public string FIO;
        public double Math;
        public double Rus;
        public double Physic;
        public double SrZn;
        public int Age;
        public int rnd = new Random().Next(1,29);
    }

    class Massiv
    {

        public static void Massiv2()
        {
            Student[] students = new Student[5];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            Console.WriteLine("Средний балл колледжа/техникума:");
            double sr = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Претенденты на поступление:");
            students[0].FIO = "Булат Феликсович";
            students[1].FIO = "Радион Батырович";
            students[2].FIO = "Андрей Дмитревьич";
            students[3].FIO = "Субудай Эртинеевич";
            students[4].FIO = "Рафиль Рамильевич";


            for (int i = 0; i < students.Length; i++)
            {
                students[i].Math = new Random().Next(2, 6);
                students[i].Physic = new Random().Next(4, 6);
                students[i].Rus = new Random().Next(2, 6);
            }
            

            for (int i = 0; i < students.Length; i++)
            {
                students[i].SrZn = (students[i].Math + students[i].Rus + students[i].Physic) / 3;
            }
            Console.WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (sr <= students[i].SrZn)
                {
                    Console.WriteLine(students[i].FIO);
                    Console.WriteLine(students[i].SrZn);
                }                
            }
            Console.WriteLine();

            for (int i = 0; i < students.Length; i++) /*общага*/
            {
                Console.WriteLine($"Проживает ли {students[i].FIO} в общежитии?(да/нет)");
                students[i].Obshaga = Console.ReadLine();
                Console.WriteLine();
                if (students[i].Obshaga == "да"| students[i].Obshaga == "Да")
                {
                    Console.WriteLine($"{students[i].FIO} проживает в общежитии");
                    Console.WriteLine();
                }
                else if(students[i].Obshaga == "нет" | students[i].Obshaga == "Нет")
                {
                    Console.WriteLine($"{students[i].FIO} не проживает в общежитии");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Возраст студента {students[i].FIO}:");
                students[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Студенту {students[i].FIO} - {students[i].Age} лет");
                Console.WriteLine();
                if (students[i].Age >= 18)
                {
                    Console.WriteLine($"Студененту {students[i].FIO} нужно подойти к 1210 кабинету и провакцинироваться {students[i].rnd} числа этого месяца");
                    Console.WriteLine();
                }
                else if (students[i].Age < 18)
                {
                    
                }
                else 
                {
                    Console.WriteLine("Введены некорректные данные");
                }
            }

        }/* конец метода */
    }/* конец класса Massiv2 */
    public class Vizov
    {
        public static void Main()
        {
            Massiv.Massiv2();
        }
    }
}