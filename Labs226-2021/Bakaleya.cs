using System;


namespace Labs226_2021
{
    class Bakaleya
    {
        public static void Pokypka()
        {
            string[] array = new string[10] { "Хлеб", "Батон", "Молоко", "Виноград", "Яблоки", "Бананы", "Картошка", "Вишня", "Масло", "Растительное масло" };


            int[] array2 = new int[10] {34, 35, 60, 500, 80, 80, 40, 200, 120, 100};
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 || i == 1 || i == 2 || i == 8 || i == 9)
                {
                    Console.WriteLine($"{i + 1}. {array[i]} = {array2[i]} руб/шт ");
                }

                else
                {
                    Console.WriteLine($"{i + 1}. {array[i]} = {array2[i]} руб/кг ");
                }

            }

            string[] basket = new string[] { };
            Console.WriteLine("Выбирите позицию товара: ");
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1)
            {
                Console.WriteLine(array[0]);
                Console.WriteLine("Выберите количество товара");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine($"{array[0]} =  {array2[0] * choice}");

            }





                
        }

    }
}
