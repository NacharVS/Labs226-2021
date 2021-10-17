using System;

namespace Labs226_2021
{
    class Student
    {
        public string Phio;
        public double Math;
        public double Rus;
        public double Fizk;
        public double sred;
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

            Console.WriteLine("Какой будет СРЕДНИЙ БАЛЛ для поступления в МЦК-КТИТС ?");
            double sr = double.Parse(Console.ReadLine());

            students[0].Phio = "Комиссаров Карл Якунович";
            students[1].Phio = "Дорофеев Максим Денисович";
            students[2].Phio = "Соловьёв Архип Вениаминович";
            students[3].Phio = "Горшков Феликс Семенович";
            students[4].Phio = "Александров Альберт Серапионович";


            for (int i = 0; i < students.Length; i++)
            {
                students[i].Math = new Random().Next(2, 6);
                students[i].Fizk = new Random().Next(2, 6);
                students[i].Rus = new Random().Next(2, 6);
            }

            for (int i = 0; i < students.Length; i++)
            {
                students[i].sred = (students[i].Math + students[i].Rus + students[i].Fizk) / 3;
            }

            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (sr <= students[i].sred)
                {
                    Console.WriteLine(students[i].Phio);
                    Console.WriteLine(students[i].sred);
                }
                Console.WriteLine();
            }
        }
    }
}
