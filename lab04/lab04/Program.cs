using System;
using System.Collections;
using System.Collections.Generic;

namespace lab04
{
    class Program
    {
        public static List<Being> Beings { get; set; }
        public static List<ICarnivorous> Carnivorous { get; set; }
        public static List<IHerbivorous> Herbivorous { get; set; }

        public Program()
        {
            
        }

        public static void initialize()
        {
            Beings = new List<Being>();
            Carnivorous = new List<ICarnivorous>();
            Herbivorous = new List<IHerbivorous>();
            try
            {
                Beings.Add(new Spirit(12, 25, "Duszek", 0.85));
                Beings.Add(new Spirit(66, 5, "Kacper", 1.1));
                Beings.Add(new Plant(11, Plant.state.growth, "Storczyk", 0.24));
                Beings.Add(new Plant(4, Plant.state.berry, "Kaktus", 2.04));
                Beings.Add(new Rat(5, "Szczurek", 0.12));
                Beings.Add(new Boar(7, "Dzik", 1.42));
                Beings.Add(new Horse(42, "Kon", 2.21));
                Beings.Add(new Rabbit(13, "Krol", 0.43));
                Beings.Add(new Cat(17, "Kotek", 0.52));
                Beings.Add(new Dog(35, "Pies", 1.68));
                Beings.Add(new Dog(35, "Pies", 1.68));
            }
            catch(TransparencyException e)
            {
                Console.WriteLine("Type: " + e.GetType());
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("TargetSite: " + e.TargetSite);
                Console.WriteLine("StackTrace: " + e.StackTrace);
            }
            catch(SpeedException e)
            {
                Console.WriteLine("Type: " + e.GetType());
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("TargetSite: " + e.TargetSite);
                Console.WriteLine("StackTrace: " + e.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine("StackTrace: " + e.StackTrace);
            }
        }

        public static void addHerbivorous()
        {
            Beings.ForEach(i =>
            {
                if(i is IHerbivorous)
                {
                    Herbivorous.Add((IHerbivorous)i);
                }
            });
        }
        public static void addCarnivorous()
        {
            Beings.ForEach(i =>
            {
                if(i is ICarnivorous)
                {
                    Carnivorous.Add((ICarnivorous)i);
                }
            });
        }

        public static void eating()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Miesozercy:");
            Carnivorous.ForEach(c => { c.FindFood(); c.EatMeat(); Console.WriteLine("--------------------------"); });
            Console.WriteLine("=========================");
            Console.WriteLine("Roslinozercy:");
            Herbivorous.ForEach(h => { h.FindFood(); h.EatPlant(); Console.WriteLine("--------------------------"); });
        }

        public static void eatH(IHerbivorous herbivorous)
        {
            herbivorous.FindFood();
            herbivorous.EatPlant();
        }
        public static void eatC(ICarnivorous carnivorous)
        {
            carnivorous.FindFood();
            carnivorous.EatMeat();
        }

        static void Main(string[] args)
        {
            Program.initialize();
            /*try
            {
                new Spirit(102, 1, "ZlyDuszek", 0.1);
            }
            catch (TransparencyException e)
            {
                Console.WriteLine("Type: " + e.GetType());
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("TargetSite: " + e.TargetSite);
                Console.WriteLine("StackTrace: " + e.StackTrace);
            }*/
            Program.addHerbivorous();
            Program.addCarnivorous();
            Program.eating();
            Program.eatH(new Horse(22, "Konik", 1.21));
            Program.eatC(new Dog(11, "Piesek", 0.68));
            Rat b = new Rat(12, "Szczurek", 12);
            Console.WriteLine("----------O szczurku:------------");
            ((ICarnivorous)b).FindFood();
            ((IHerbivorous)b).FindFood();


            Human marcin = new Human(30, 150, "Marcin", 195)
            {
                cars = new List<Car>
                {
                    new Car("Citroen", 1000000),
                    new Car("Scoda Rapid", 50000),
                    new Car("Scoda Yeti", 80000)
                },
                houses = new List<House>
                {
                    new House(51, 210000),
                    new House(110, 300000),
                    new House(25, 20000),
                }
            };
            Human hubert = new Human(99, 34, "Hubcio", 179)
            {
                cars = new List<Car>
                {
                    new Car("BMW", 400000),
                    new Car("Audi", 90000),
                    new Car("Mercedes", 10000)
                },
                houses = new List<House>
                {
                    new House(55, 212000),
                    new House(100, 290000),
                    new House(22, 22030),
                    new House(220, 220300)
                }
            };
            Console.WriteLine("\n-------Mieszkania Marcina:--------------");
            foreach(House h in marcin.GetHouses())
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("\n-------Samochody Marcina:--------------");
            foreach (Car x in marcin)
            {
                Console.WriteLine(x);
            }


            Human klon = (Human) marcin.Clone();
            Console.WriteLine("\nKlonowane samochody:");
            foreach(Car k in klon)
            {
                Console.WriteLine(k);
            }
            

            Console.WriteLine("\nPorownanie IQ: "+marcin.CompareTo(hubert));
            Console.WriteLine("Porownanie ilosci domow: "+Human.Compare(new HouseComparer(),marcin, hubert));
            Console.WriteLine("Porownanie ilosci samochodow: "+Human.Compare(new CarComparer(),marcin, hubert));
            Console.WriteLine("Porownanie wydatkow: "+Human.Compare(new SpendComparer(),marcin, hubert));

        }
    }
}
