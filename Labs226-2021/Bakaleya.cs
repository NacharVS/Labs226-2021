using System;


namespace Labs226_2021
{
    class Bakaleya
    {
        public static void Pokypka()
        {
            string[] array = new string[10] { "Хлеб", "Батон", "Молоко", "Виноград", "Яблоки", "Бананы", "Картошка", "Вишня", "Масло", "Растительное масло" };
            double[] basket = new double[10];
            double[] price = new double[10];

            string[] kg = new string[10] { "-", "-", "-", "Виноград", "Яблоки", "Бананы", "Картошка", "Вишня", "-", "-" };

            string stop = "Нет";
            string ans = "Да";
            double res = 0;
            int tovar = 0;

            int[] array2 = new int[10] { 34, 35, 60, 500, 80, 80, 40, 200, 120, 100 };
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

            Console.WriteLine();


            while(stop != ans)
            {
                Console.WriteLine("Выберите позицию товара: ");
                tovar = int.Parse(Console.ReadLine());
                tovar -= 1;

                Console.WriteLine("Выберите шт/граммах товара: ");
                basket[tovar] = double.Parse(Console.ReadLine());

                Console.WriteLine();
                if(array[tovar] == kg[tovar])
                {
                    Console.WriteLine($"{array[tovar] } = {array2[tovar] * (basket[tovar]) / 1000}");
                    
                }
                else
                {
                    Console.WriteLine($"{array[tovar] } = {array2[tovar] * basket[tovar]}");
                }

                Console.WriteLine();
                Console.WriteLine("Хотите ли вы продолжить покупку?\nНапишите 'Да' или 'Нет' ");
                ans = Console.ReadLine();
                Console.WriteLine();

                
            }
            Console.WriteLine("_______________");
            for (int i = 0; i < basket.Length - 1; i++)
            {
                if(basket[i] != 0)
                {
                    if(array[i] == kg[i])
                    {
                        price[i] = array2[i] * (basket[i] / 1000 );
                    }
                    else
                    {
                        price[i] = array2[i] * basket[i];
                    }
                    
                    Console.WriteLine($"{array[i]} = {price[i]}");

                }

            }

            for (int i = 0; i < price.Length -1; i++)
            {
                res = res + price[i];

                
            }
            Console.Write("Итого: ");
            Console.WriteLine(res);

        }
    }
}
