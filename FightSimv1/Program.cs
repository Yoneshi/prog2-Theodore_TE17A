using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimv1
{
    class Fighter
    {
        Random generator = new Random(); // skapar en generator

        private int hp; // private variabel för hitpoints
        public string name; 
        public int Attack() // En metod som skapar attacken 
        {

            return generator.Next(80);// denna returnar en random int som är under 80 men över 0

        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter(); 

            f1.Attack(); // kallar på attack metoden

            

            Console.WriteLine(f1.Attack()); // skriver ut attack metoden.
            
            
            Console.ReadLine();




        }
    }
}
