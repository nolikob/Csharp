using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_09
{
    class Plane
    {
        private int Year { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public Plane(int year,string name,int capacity)
        {
            Year = year;
            Name = name;
            Capacity = capacity;
        }
        /*
        public string basicInfo()
        {
            return String.Format("Plane {2} was made in {0}, has capacity for {1} people.",Year,Capacity,Name);
        }
        */
        public void newPassangers(int amount)
        {
            Capacity -= amount;
            Console.WriteLine("New plane capacity: {0}", Capacity);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vytvořte jednoduchou třídu, která bude reprezentovat letadlo. 
             * Uživatele vyzvěte, aby postupně zadal rok výroby, název letadla a kapacitu sedadel. 
             * Jakmile data načtete, vytvořte instanci této třídy.
             * 
             * Třídu reprezentující letadlo (z příkladu 9) rozšiřte o metodu, která se bude volat tehdy, když do letadla přistoupí další pasažéři. 
             * Počet pasažérů může být jeden či více. Nemusíte ošetřovat situace, jako např. že by se do letadla již pasažéři nevešli.
             */
            int year = int.Parse(Console.ReadLine());
            string planeName = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            Plane myPlane = new Plane(year, planeName, capacity);
            myPlane.newPassangers(120);
            //Console.WriteLine(myPlane.basicInfo());
            Console.ReadKey();
        }
    }
}
