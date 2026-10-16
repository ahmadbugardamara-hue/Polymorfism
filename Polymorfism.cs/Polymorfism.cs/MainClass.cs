using System;

namespace GamePolymorphism
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Hero h = new Hero();
            h = new Knight();  // polimorfisme
            h = new Wizard();  // polimorfisme

            // Knight k = new Wizard(); 
            // ERROR: tidak bisa karena Wizard bukan subclass Knight
        }
    }
}
