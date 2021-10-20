using System;

namespace Labs226_2021
{
    class Student
    {
        public string vac;
        public string Phio;
        public double Math;
        public double Rus;
        public double Fizk;
        public double sred;
        public int Obsh;
        public int age;
        
    }

    class Massiv
    {
        
        public static void Massiv2()
        {
            Student[] students = new Student[5];
            string[] vacs = new string[2] {"Да", "Нет"};
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            students[0].Phio = "Комиссаров Карл Якунович";
            students[1].Phio = "Дорофеев Максим Денисович";
            students[2].Phio = "Соловьёв Архип Вениаминович";
            students[3].Phio = "Горшков Феликс Семенович";
            students[4].Phio = "Александров Альберт Серапионович";

            //Random rnd = new Random();
            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i].vac = rnd.Next(vacs.Length);
            //}

            for (int i = 0; i < students.Length; i++)
            {
                students[i].age = new Random().Next(16, 19);
            }

            for (int i = 0; i < students.Length; i++)
            {
                students[i].Math = new Random().Next(2, 6);
                students[i].Fizk = new Random().Next(2, 6);
                students[i].Rus = new Random().Next(2, 6);
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i].Phio}: Математика {students[i].Math}, Физика {students[i].Fizk}, Русский {students[i].Rus};  {students[i].age} лет");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Какой будет СРЕДНИЙ БАЛЛ ?");
            double sr = double.Parse(Console.ReadLine());

            for (int i = 0; i < students.Length; i++)
            {
                
                students[i].Obsh = new Random().Next(1, 3);
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
                    if (students[i].Obsh == 1)
                    {
                        Console.WriteLine($"{students[i].Phio} (Живет в общежитии)");
                    }
                    else
                    {
                        Console.WriteLine($"{students[i].Phio} (Не живет в общежитии)");
                    }
                    Console.WriteLine(students[i].sred);
                }
                Console.WriteLine();
            }

            Console.WriteLine("________________________________________");
            Console.WriteLine("Вывести студентов, которым есть 18 лет ?");
            string otvet = Console.ReadLine();
            Console.WriteLine();
            if (otvet == "Да" || otvet == "да" || otvet == "Yes" || otvet == "yes")
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].age >= 18)
                    {
                        if (sr <= students[i].sred)
                        {
                            if (students[i].Obsh == 1)
                            {
                                Console.WriteLine($"{students[i].Phio} (Живет в общежитии)");
                            }
                            else
                            {
                                Console.WriteLine($"{students[i].Phio} (Не живет в общежитии)");
                            }
                            Console.WriteLine(students[i].sred);
                        }
                        Console.WriteLine();
                    }
                }
            }


            //Console.WriteLine("________________________________________");
            //Console.WriteLine("Вывести студентов, которые вакцинированы?");
            //string otvets = Console.ReadLine();
            //Console.WriteLine();
            //if (otvet == "Да" || otvet == "да" || otvet == "Yes" || otvet == "yes")
            //{
            //    for (int i = 0; i < students.Length; i++)
            //    {
            //        if (students[i].age >= 18)
            //        {
            //            if (sr <= students[i].sred)
            //            {
            //                if (students[i].Obsh == 1)
            //                {
            //                    Console.WriteLine($"{students[i].Phio} (Живет в общежитии)");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{students[i].Phio} (Не живет в общежитии)");
            //                }
            //                Console.WriteLine(students[i].sred);
            //            }
            //            Console.WriteLine();
            //        }
            //    }
            //}




        }
    }
}
