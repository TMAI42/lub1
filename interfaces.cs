using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1123
{
    abstract class Thing
    {
        public string Name { get; set; }
        
        public Thing(string Name)
        {
            this.Name = Name;
        }

        public abstract void AboutMe();
    }

    interface IFlying
    {
        void Fly();
    }

    interface ISwimming
    {
        void Swim();
    }

    interface IRunning
    {
        void Run();
    }

    interface IThruster
    {
        void HaveThruster();
    }

    class Plane : Thing, IThruster, IFlying
    {
        public Plane(string Name) : base(Name) { }

        public void HaveThruster()
        {
            Console.WriteLine("I have big Thruster");
        }

        public void Fly()
        {
            Console.WriteLine("I fly in space ");
        }

        public override void AboutMe()
        {
            Console.WriteLine(this.Name);
            this.Fly();
            this.HaveThruster();
        }
    }

    class Eagle: Thing, IFlying, ISwimming
    {
        public Eagle(string Name) : base(Name) { }

        public void Fly()
        {
            Console.WriteLine("I fly to the nest ");
        }

        public void Swim()
        {
            Console.WriteLine("I cath Fish under the water");
        }

        public override void AboutMe()
        {
            Console.WriteLine(this.Name);
            this.Swim();
            this.Fly();
        }

    }
    
    class Duck:Thing, IFlying, ISwimming
    {
        public Duck(string Name) : base(Name) { }

        public void Fly()
        {
            Console.WriteLine("I can Fly, but not high ");
        }

        public void Swim()
        {
            Console.WriteLine("I swim in a lake ");
        }

        public override void AboutMe()
        {
            Console.WriteLine(this.Name);
            this.Fly();
            this.Swim();
        }

    }

    class Chicken : Thing, IRunning, ISwimming
    {
        public Chicken(string Name) : base(Name) { }

        public void Run()
        {
            Console.WriteLine("I can Run fast ");
        }

        public void Swim()
        {
            Console.WriteLine("I swim, but not good ");
        }

        public override void AboutMe()
        {
            Console.WriteLine(this.Name);
            this.Run();
            this.Swim();
        }

    }

    class Rabbit : Thing, IRunning
    {
        public Rabbit(string Name) : base(Name) { }

        public void Run()
        {
            Console.WriteLine("I can Run stealcy ");
        }

        public override void AboutMe()
        {
            Console.WriteLine(this.Name);
            this.Run();
        }

    }



    class ThusterBoat :Thing, ISwimming, IThruster
    {
        public ThusterBoat(string Name) : base(Name) { }

        public void Swim()
        {
            Console.WriteLine("I can swim fast");
        }

        public void HaveThruster()
        {
            Console.WriteLine("I have small Thruster");
        }

        public override void AboutMe()
        {
            Console.WriteLine(this.Name);
            this.Swim();
            this.HaveThruster();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFlying[] flying = { new Plane("qwer"), new Duck("qwert"), new Eagle("eagle") };
            foreach(IFlying f in flying){(f as Thing).AboutMe();}
            ISwimming[] swimmings = { new Duck("duck"), new ThusterBoat("Boat"), new Chicken("chicken"), new Eagle("eagle") };
            foreach (ISwimming f in swimmings) { (f as Thing).AboutMe(); }
        }
    }
}
