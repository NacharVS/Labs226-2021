using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    public class student
    {
        public string Obsh;
        public string Fio;
        public int rus;
        public int Fiz;
        public int math;
        public float sr;

    }
    public class masss
    {
        public static void massss()
        {

            student[] students = new student[5];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new student();
            }
            for (int i = 0; i < students.Length; i++)
            {
                int rus = rnd.Next(2, 6);
                int fiz = rnd.Next(2, 6);
                int math = rnd.Next(2, 6);
                students[i].rus = rus;

                students[i].Fiz = fiz;
                students[i].math = math;
            }
            students[0].Fio = ("Alan");
            students[1].Fio = ("Anton");
            students[2].Fio = ("Albert");
            students[3].Fio = ("Biburat");
            students[4].Fio = ("Vlad");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Оценки " + $"{ students[i].Fio }");
                Console.WriteLine();
                Console.Write("Русский " + $"{students[i].rus}" + " Физика " + $" { students[i].Fiz} " + " Математика " + $"{ students[i].math } ");
                Console.WriteLine();
                students[i].sr = (students[i].rus + students[i].Fiz + students[i].math) / 3f;
                Console.WriteLine();
                Console.Write("Средний балл = ");
                Console.Write(students[i].sr = (students[i].rus + students[i].Fiz + students[i].math) / 3f);
                Console.WriteLine();
                Console.WriteLine();
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Живёт ли " + $" {students[i].Fio} " +"в общежитии?") ;
                students[i].Obsh =Console.ReadLine();
            }
            Console.WriteLine("Введите средний балл");
            double ser = double.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].sr >= ser)
                {
                    Console.WriteLine();
                    Console.Write($"{students[i].Fio }");
                    Console.Write($" { students[i].sr }");
                    Console.WriteLine();
                    if (students[i].Obsh == "да")
                    {
                        Console.WriteLine("Из них в общежитии живут:");                      
                        Console.Write($"{students[i].Fio }");
                    }
                }

            }
        }






    }
    public class Jurnal
    {
        public static void Jurnall()
        {

            student[] students = new student[5];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new student();
            }
          
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Запишите имя");
                students[i].Fio = (Console.ReadLine());
                Console.WriteLine("Запишите Оценку по Русскому");
                int rus = int.Parse(Console.ReadLine());
                Console.WriteLine("Запишите Оценку по Физике");
                int fiz = int.Parse(Console.ReadLine());
                Console.WriteLine("Запишите Оценку по Математике");
                int math = int.Parse(Console.ReadLine());
                students[i].rus = rus;

                students[i].Fiz = fiz;
                students[i].math = math;
            }
            
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Оценки " + $"{ students[i].Fio }");
                Console.WriteLine();
                Console.Write("Русский " + $"{students[i].rus}" + " Физика " + $" { students[i].Fiz} " + " Математика " + $"{ students[i].math } ");
                Console.WriteLine();
                students[i].sr = (students[i].rus + students[i].Fiz + students[i].math) / 3f;
                Console.WriteLine();
                Console.Write("Средний балл = ");
                Console.Write(students[i].sr = (students[i].rus + students[i].Fiz + students[i].math) / 3f);
                Console.WriteLine();
                Console.WriteLine();
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Живёт ли " + $" {students[i].Fio} " + "в общежитии?");
                students[i].Obsh = Console.ReadLine();
            }
            Console.WriteLine("Введите средний балл");
            double ser = double.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].sr >= ser)
                {
                    Console.WriteLine();
                    Console.Write($"{students[i].Fio }");
                    Console.Write($" { students[i].sr }");
                    Console.WriteLine();
                    if (students[i].Obsh == "да")
                    {
                        Console.WriteLine("Из них в общежитии живут:");
                        Console.Write($"{students[i].Fio }");
                    }
                }

            }
        }
    }
}


    
   




