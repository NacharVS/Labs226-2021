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
        public int vozr;
        public string data;
        public string vakchen;
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
                students[i].vozr = rnd.Next(15, 23);
            }
            int mes = rnd.Next(1, 13);
            int den = rnd.Next(1, 31);
            students[0].Fio = ("Alan " + $"{den}." + $"{mes}." + $"{2021 - students[0].vozr}");
            mes = rnd.Next(1, 13);
            den = rnd.Next(1, 31);
            students[1].Fio = ("Anton " + $"{den}." + $"{mes}." + $"{2021 - students[1].vozr}");
            mes = rnd.Next(1, 13);
            den = rnd.Next(1, 31);
            students[2].Fio = ("Albert " + $"{den}." + $"{mes}." + $"{2021 - students[2].vozr}");
            mes = rnd.Next(1, 13);
            den = rnd.Next(1, 31);
            students[3].Fio = ("Biburat " + $"{den}." + $"{mes}." + $"{2021 - students[3].vozr}");
            mes = rnd.Next(1, 13);
            den = rnd.Next(1, 31);
            students[4].Fio = ("Vlad " + $"{den}." + $"{mes}." + $"{2021 - students[4].vozr}");

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].vozr >= 18)
                {
                    Console.WriteLine("Вакцинирован ли студент  " + $"{students[i].Fio}");
                    students[i].vakchen = (Console.ReadLine());
                }
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Оценки " + $"{ students[i].Fio }");

                Console.Write("Русский " + $"{students[i].rus}" + " Физика " + $" { students[i].Fiz} " + " Математика " + $"{ students[i].math } ");
                Console.WriteLine();
                students[i].sr = (students[i].rus + students[i].Fiz + students[i].math) / 3f;

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
                    if (students[i].Obsh == "да")
                    {
                        if (students[i].vozr >= 18)
                        {
                            Console.Write("Живет в общежитии и совершеннолетний   ");
                            Console.Write($"{ students[i].Fio }");
                            Console.Write($" { students[i].sr }");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("Живет в общежитии и несовершеннолетний ");
                            Console.Write($"{ students[i].Fio }");
                            Console.Write($" { students[i].sr }");
                            Console.WriteLine();
                        }
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("Обезательна вакцина для:");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].vakchen != "да" && students[i].vozr >= 18)
                {
                    Console.WriteLine($"{students[i].Fio}");
                }
            }
        }
    }
}