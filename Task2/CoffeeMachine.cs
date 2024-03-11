using System;

namespace coffeemachine
{
    public class CoffeeMachine
    {
        int water, milk, beans, cups;

        public CoffeeMachine(int water = 400,
                             int milk = 540,
                             int beans = 120,
                             int cups = 9)
        {
            this.water = water;
            this.milk = milk;
            this.beans = beans;
            this.cups = cups;
        }

        void PrintState()
        {
            Console.Clear();

            Console.WriteLine("\nВыбирите действие ");
            Console.WriteLine("\n 1 остаток воды");
            Console.WriteLine("\n 2 остаток кофе");
            Console.WriteLine("\n 3 остаток молока");
            Console.WriteLine("\n 4 остаток стаканчиков");
            Console.WriteLine("\n 5 назад");


            switch (Console.ReadLine())
            {

                case "5":
                    Start();
                    break;

                case "1":
                    Console.WriteLine("Вода мл:");
                    Console.WriteLine(this.water);
                    Water(water);
                    break;
                case "2":
                    Console.WriteLine("Кофе мл:");
                    Console.WriteLine(this.milk);
                    Milk(milk);
                    break;
                case "3":
                    Console.WriteLine("Молоко мл:");
                    Console.WriteLine(this.milk);
                    Beans(beans);
                    break;
                case "4":
                    Console.WriteLine("Стаканчики шт:");
                    Console.WriteLine(this.cups);
                    Cups(cups);
                    break;


                default:
                    Console.WriteLine("Выбранный вариант не существует.");
                    break;
            }

        }

        void Water(int water)
        {
            this.water += water;

        }
        void Milk(int milk)
        {
            this.milk += milk;
        }
        void Beans(int beans)
        {
            this.beans += beans;
        }
        void Cups(int cups)
        {
            this.cups += cups;
        }



        // void Product(Cappucino)
        // {
        //     Console.WriteLine("\nВыберите продукт для приготовления :");

        // }

        public void Start()
        {
            bool exit = false;
            Console.Clear();
            while (!exit)
            {

                Console.WriteLine("\nВыбирите действие ");
                Console.WriteLine("\n 1 менюь добавление ингредиентов");
                Console.WriteLine("\n 2 меню остатков ингридиентов");
                Console.WriteLine("\n 3 меню приготовления напитков");
                Console.WriteLine("\n 4 очистить кофемашину");
                Console.WriteLine("\n 5 история приготовления");
                Console.WriteLine("\n 6 приготовить свой напиток");

                Console.WriteLine("\n 0 Выключить кофемашину");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Кофемашина выключена.");
                        exit = true;
                        break;
                    case "1":
                        Addition();
                        break;
                    case "2":
                        PrintState();
                        break;
                    case "3":
                        Cooking();
                        break;
                    case "4":
                        Cleaning();
                        break;
                    case "5":
                        Story();
                        break;

                    // case "5":
                    //     Product();
                    //     break;

                    default:
                        Console.WriteLine("Выбранный вариант не существует.");
                        break;
                }
            }
        }
        public void Addition()
        {
            Console.Clear();



            Console.WriteLine("\nВыбирите действие ");
            Console.WriteLine("\n 1 добавить воды");
            Console.WriteLine("\n 2 добавить кофе");
            Console.WriteLine("\n 3 добавить молока");
            Console.WriteLine("\n 4 добавить стаканчики");
            Console.WriteLine("\n 5 назад");
            switch (Console.ReadLine())
            {

                case "5":
                    Start();
                    break;

                case "1":
                    Console.WriteLine("Напишите, сколько мл воды вы хотите добавить:");
                    int water = Int32.Parse(Console.ReadLine());
                    Water(water);
                    break;
                case "2":
                    Console.WriteLine("Напишите, сколько граммов кофейных зерен вы хотите добавить:");
                    int beans = Int32.Parse(Console.ReadLine());
                    Beans(beans);
                    break;
                case "3":
                    Console.WriteLine("Напишите, сколько мл малока вы хотите добавить:");
                    int milk = Int32.Parse(Console.ReadLine());
                    Milk(milk);
                    break;
                case "4":
                    Console.WriteLine("Напишите, сколько одноразовых стаканчиков вы хотите добавить:");
                    int cups = Int32.Parse(Console.ReadLine());
                    Cups(cups);
                    break;


                default:
                    Console.WriteLine("Выбранный вариант не существует.");
                    break;
            }
        }
       Products products;
        public void Cooking(Products Espresso)
        {
           
            
            Console.Clear();
            Console.WriteLine("\nВыбирите действие ");
            Console.WriteLine("\n 1 Espresso");
            Console.WriteLine("\n 2 Latte");
            Console.WriteLine("\n 3 Cappucino");
            Console.WriteLine("\n 5 назад");
            switch (Console.ReadLine())
            {

                case "5":
                    Start();
                    break;

                case "1":
                    
                    // Console.WriteLine(CoffeeNames.Espresso);
                    // Console.WriteLine("\nВаш напиток: {Products.Espresso}");
                    Console.WriteLine($" \nВаш напиток готов: {Espresso}");
                    
                    // return Espresso;
                    break;
                case "2":

                    break;
                case "3":


                default:
                    Console.WriteLine("Выбранный вариант не существует.");
                    break;
            }
        }
        
        public void Story()
        {

            Console.Clear();




            Console.WriteLine("\n 5 назад");
            switch (Console.ReadLine())
            {

                case "5":
                    Start();
                    break;

                case "1":





                default:
                    Console.WriteLine("Выбранный вариант не существует.");
                    break;
            }
        }
        public void Cleaning()
        {

            Console.Clear();




            Console.WriteLine("\n 5 назад");
            switch (Console.ReadLine())
            {

                case "5":
                    Start();
                    break;

                case "1":





                default:
                    Console.WriteLine("Выбранный вариант не существует.");
                    break;
            }
        }
    }
}