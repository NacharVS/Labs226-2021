using System;

namespace Ocenki
{
    public class Student
    {

        public string FIO;
        public double math;
        public double fizik;
        public double angl;
        
        
    }
    public class Std
    {
        public static void Main()
        {
            Student[] stds = new Student[5];
            Random rnd = new Random();
            for(int i= 0; i < stds.Length; i++)
            {
                stds[i] = new Student();
            }
            for (int i = 0; i < stds.Length; i++)
            {
                
                double math = rnd.Next(1, 6);
                stds[i].math = math;
                double fizik = rnd.Next(1, 6);
                stds[i].fizik = fizik;
                double angl = rnd.Next(1, 6);
                stds[i].angl = angl;
            }
            stds[0].FIO = "Зиятдинов Булат";
            stds[1].FIO = "Зайнетдинов Вильдан";            
            stds[2].FIO = "Рахимов Радеон";
            stds[3].FIO = "Анисимов Владислав";            
            stds[4].FIO = "Гайнетдинов Алан";

            Console.WriteLine(stds[0]);
        }
    }
        class Vizov
    {
        public static void Vizovv()
        {
            Std.Main();
        }
    }

        
    
}
