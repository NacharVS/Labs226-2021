using System;

namespace StudentsSrBall
{
    public class Student
    {
        public string F;
        public string I;
        public string O;
        public int Matan;
        public int OdinC;
        public int SiSharp;
    }
    public class Std
    {
        public static void Main()
        {
            Student[] students = new Student[5];
            Random rndm = new Random();
            for (int i = 0; 1 < students.Length; i++)
            {
                students[i] = new Student();
            }
            for (int k=0; 1<students.Length; k++)
            {
                int a = rndm.Next(2, 6);
                int b = rndm.Next(2, 6);
                int c = rndm.Next(2, 6);
                students[k].Matan = a;
                students[k].OdinC = b;
                students[k].SiSharp = c;
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
            Console.WriteLine(students);
        }
    }
    class Vivod
    {
        public static void Pupsik ()
        {
            Std.Main();
        }
    }
}
