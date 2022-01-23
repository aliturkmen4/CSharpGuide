using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba a1 = new Araba("2500");
            a1.motor.motorGucu = 1500;
            Console.WriteLine(a1.motor.motorGucu);
            Console.ReadLine();
        }
    }
    class Araba
    {
        public string model;
        public Motor motor;
        public Araba(string mot)
        {
            motor = new Motor();
            
        }
        //public Motor motor ; //motor class'ından obje üretip araba class'ının alt objesi yaptım!
        public class Motor
        {
            public int motorGucu;
        }
    }
}
