using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace S.Exam
{
    class Program
    {
        public class DrinkContainer
        {
            protected int content;
            protected int capasity;
            private const int DEFAULT_CAPASITY = 1000;

            public DrinkContainer()
            {
                capasity = 1000;
            }

            public DrinkContainer(int cap)
            {
                if (cap > 0)
                {
                    capasity = cap;
                }
            }

            public DrinkContainer(int cap, int con)
            {
                if (cap > 0 )
                {
                    capasity = cap;
                }
                if (con > 0 && con <= cap)
                {
                    content = con;
                }
            }

            public int GetContent()
            {
                return content;
            }

            public int Drain(int remove)
            {
                    content -= remove;
                    return 0;
            }

            public int Fill(int add)
            {
                if (add <= content)
                {
                    content += add;
                    return 0;
                }
                else
                    return Drain(capasity - add);
            }

            public override string ToString()
            {
                return "DrinkContainer: " + content + "/" + capasity + "ml";
            }



        }

        public enum Tribe { NorthInvader, SouthMonster, CreepyWalker };

        public abstract class Warrior : IDrinkable
        {
            protected string name;
            protected Tribe tribe;
            protected DrinkContainer drinkCont;


            public Warrior(string nm, Tribe tb)
            {
                name = nm;
                tribe = tb;
            }

            public DrinkContainer Pick(DrinkContainer pick_DC)
            {
                drinkCont = pick_DC;
                return drinkCont;
            }

            public DrinkContainer Drop()
            {
                return drinkCont = null;
            }

            public void Sip()
            {
               
            }

            public void Drink()
            {
                
            }

            public override string ToString()
            {
                return "Name: " + name + "Tribe: " + tribe + " " + drinkCont;
            }

        }

        public interface IDrinkable
        {

            public void Drink(DrinkContainer dc1)
            {
               
            }
        }

        public class ServiceWarrior : Warrior
        {

            public ServiceWarrior(string nm, Tribe tb) : base(nm, tb)
            {
            }

            public void OfferDrink(Warrior friend)
            {
                
            }
        }

        public class ChiefWarrior : Warrior
        {
            public ChiefWarrior(string nm, Tribe tb) : base(nm, tb)
            {
            }

            public DrinkContainer Drink ()
            {
                return null;
            }
        }

        public class DrinkColletion : DrinkContainer
        {
            protected List<DrinkContainer> drinks = new List<DrinkContainer>();

            public DrinkColletion(DrinkContainer drink)
            {
                drinks.Add(drink);
            }

            public DrinkColletion(List<DrinkContainer> ds)
            {
                drinks = ds;
            }

            public DrinkContainer AddDC(DrinkContainer drink)
            {
                drinks.Add(drink);
                return drink;
            }

            public override int Fill()
            {
                while (content < capasity)
                {
                    
                }
                return 0;
            }

            
        }





        static void Main(string[] args)
        {
            DrinkContainer cup = new DrinkContainer(1000,1000);
            Console.WriteLine(cup.ToString());
            DrinkContainer glass = new DrinkContainer(2000,2000);
            Console.WriteLine(glass.ToString());
            DrinkContainer bottle = new DrinkContainer(2000, 3000);
            Console.WriteLine(bottle.ToString());

            cup.Drain(800);
            Console.WriteLine(cup.ToString());
            glass.Fill(1500);
            Console.WriteLine(glass.ToString());


        }
    }
}
