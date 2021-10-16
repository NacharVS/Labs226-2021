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

            Console.WriteLine("Какой будет Средний балл ?");
            double sr = double.Parse(Console.ReadLine());
            
            students[0].Phio = "Иван";
            students[0].Math = 4;
            students[0].Rus = 4;
            students[0].Fizk = 4;

            students[1].Phio = "Степан";
            students[1].Math = 3;
            students[1].Rus = 5;
            students[1].Fizk = 4;

            students[2].Phio = "Гена";
            students[2].Math = 5;
            students[2].Rus = 2;
            students[2].Fizk = 4;

            students[3].Phio = "Влад";
            students[3].Math = 4;
            students[3].Rus = 5;
            students[3].Fizk = 4;

            students[4].Phio = "Булкин";
            students[4].Math = 3;
            students[4].Rus = 3;
            students[4].Fizk = 3;


            for (int i = 0; i < students.Length; i++)
            {
                students[i].sred = (students[i].Math + students[i].Rus + students[i].Fizk) / 3;        
            }

            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                if( sr <= students[i].sred)
                {
                    Console.WriteLine(students[i].Phio);
                    Console.WriteLine(students[i].sred);
                }
            }





        }




    }
}
