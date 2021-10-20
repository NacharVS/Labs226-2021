using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    public class Student
    {
        public string F;
        public string I;
        public string O;
        public int Matan;
        public int OdinC;
        public int SiSharp;
        public double srball;
    }
    public class Std
    {
        public static void StudArray()
        {
            Student[] students = new Student[5];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }
            students[0].F = "Рахимов";
            students[0].I = "Радион";
            students[0].O = "Батырович";
            students[1].F = "Нахимов";
            students[1].I = "Надион";
            students[1].O = "Натырович";
            students[2].F = "Захимов";
            students[2].I = "Задион";
            students[2].O = "Затырович";
            students[3].F = "Шахимов";
            students[3].I = "Щадион";
            students[3].O = "Шатырович";
            students[4].F = "Фахимов";
            students[4].I = "Фадион";
            students[4].O = "Фатырович";
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Matan = new Random().Next(2, 6);
                students[i].SiSharp = new Random().Next(2, 6);
                students[i].OdinC = new Random().Next(2, 6);
            }
            for (int i = 0; i < students.Length; i++)
            {
                students[i].srball = (students[i].Matan + students[i].SiSharp + students[i].OdinC) / 3;
            }
            Console.WriteLine("Ученики с каким средним баллом вам нужны?");
            double SrVivod = double.Parse(Console.ReadLine());
            for (int i = 0; i < students.Length; i++)
            {
                if (SrVivod <= students[i].srball)
                {
                    Console.WriteLine($"Думаю, вам подходит студент с фамилией {students[i].F}");
                    Console.WriteLine($"Его средний балл {students[i].srball}");
                }
                Console.WriteLine();
            }
        }
    }
    public class Vivod
    {
        public static void Main()
        {
            Std.StudArray();
        }
    }
}