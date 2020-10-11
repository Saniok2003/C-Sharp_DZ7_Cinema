using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csahrp_5._1
{
    abstract class Creature
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\n";
        }
    }
    abstract class Animal : Creature
    {
        public double weight { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Weight: {weight}";
        }
    }
    class Fish : Animal, ISwimable
    {
        bool isSwiming = true;
        public bool IsSwiming
        {
            get
            {
                return isSwiming;
            }
            set
            {
                isSwiming = value;
            }
        }
        public string Swiming()
        {
            return "Swim.....";
        }
        public string Eat()
        {
            return "Eat....";
        }
    }
    class Bird : Animal, IFlyable
    {
        bool isFly = true;
        public bool IsFly
        {
            get
            {
                return isFly;
            }
            set
            {
                isFly = value;
            }
        }
        public string Fly()
        {
            return "Fly.....";
        }
        public string Eat()
        {
            return "Eat....";
        }
    }
    class Mammal : Animal, IRunable
    {
        bool isRun = true;
        public bool IsRun
        {
            get
            {
                return isRun;
            }
            set
            {
                isRun = value;
            }
        }
        public string Run()
        {
            return "Run.....";
        }
        public string Eat()
        {
            return "Eat....";
        }
    }
    class Reptile : Animal, ICrowable
    {
        bool isCrowl = true;
        public bool IsCrowl
        {
            get
            {
                return isCrowl;
            }
        }
        public string Crowl()
        {
            return "Crowl.....";
        }
        public string Eat()
        {
            return "Eat....";
        }
    }
    interface IRunable
    {
        bool IsRun { get; set; }
        string Run();
        string Eat();
    }
    interface ICrowable
    {
        bool IsCrowl { get; }
        string Crowl();
        string Eat();
    }
    interface IFlyable
    {
        bool IsFly { get; set; }
        string Fly();
        string Eat();
    }
    interface ISwimable
    {
        bool IsSwiming { get; set; }
        string Swiming();
        string Eat();
    }
    class Bear : Mammal, IRunable
    {
        public void Stop()
        {
            IsRun = false;
        }
        public void Say()
        {
            Console.WriteLine("Rrrrrrrrrrrrrrrr r r r rrrrrrr\n");
        }

    }
    class Dolphin : Mammal, ISwimable
    {
        bool isSwiming = true;
        public bool IsSwiming
        {
            get
            {
                return isSwiming;
            }
            set
            {
                isSwiming = value;
            }
        }
        public void Say()
        {
            Console.WriteLine("....\n");
        }
        public string Swiming()
        {
            return "Swim.....";
        }
        void EmergeJump()
        {
            Console.WriteLine("Jump out of the water");
        }
    }
    class Carp : Fish, ISwimable
    {
        public void Stop()
        {
            IsSwiming = false;
        }
        public void Say()
        {
            Console.WriteLine("Bul-bullll\n");
        }
    }
    class Eagle : Bird, IFlyable
    {
        public void ToLand()
        {
            Console.WriteLine("Landing....");
            IsFly = false;
        }
        public void Say()
        {
            Console.WriteLine("....\n");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Bear b = new Bear()
            {
                Name = "Balu",
                weight = 190
            };
            Console.WriteLine(b.ToString());
            b.Say();
        }
    }
}
