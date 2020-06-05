using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string NameArg, int CalArg, bool SpicyArg, bool SweetArg){
            Name = NameArg;
            Calories = CalArg;
            IsSpicy = SpicyArg;
            IsSweet = SweetArg;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("apple", 1000, false, false),
            new Food("banana", 400, true, false),
            new Food("cherry", 600, true, false),
            new Food("grape", 1200, false, true),
            new Food("peach", 2000, false, true),
            new Food("orange", 100, true, true),
            new Food("mango", 200, false, false),
        };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja(){
            calorieIntake = 0;
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull{
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                } 
                else 
                {
                    return false;
                }
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            calorieIntake += item.Calories;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Buffet MyBuffet = new Buffet();
            Ninja MyNinjaOne = new Ninja();
            Ninja MyNinjaTwo = new Ninja();

            Console.WriteLine("Ninja One");
            Console.WriteLine(MyNinjaOne.IsFull);
            MyNinjaOne.Eat(MyBuffet.Menu[4]);
            Console.WriteLine(MyNinjaOne.IsFull);

            Console.WriteLine("Ninja Two");
            Console.WriteLine(MyNinjaTwo.IsFull);
            MyNinjaTwo.Eat(MyBuffet.Menu[5]);
            Console.WriteLine(MyNinjaTwo.IsFull);
            MyNinjaTwo.Eat(MyBuffet.Menu[6]);
            Console.WriteLine(MyNinjaTwo.IsFull);
            MyNinjaTwo.Eat(MyBuffet.Menu[2]);
            Console.WriteLine(MyNinjaTwo.IsFull);
            MyNinjaTwo.Eat(MyBuffet.Menu[2]);
            Console.WriteLine(MyNinjaTwo.IsFull);
        }
    }
}
