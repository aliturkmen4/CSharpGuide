using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vektor v1 = new Vektor(1,2);
            Vektor v2 = new Vektor(2,5); //Instance(örnek)
            Vektor v3 = v1 + v2;
            Console.WriteLine(v3.X + " " + v3.Y);
            Console.ReadLine();
        }
    }
    class Vektor
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vektor(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vektor operator+(Vektor a,Vektor b) //matematiksel işlem varsa static koy!
        {
            int yenivektorx = a.X + b.X;
            int yenivektory = a.Y + b.Y;
            Vektor c = new Vektor(yenivektorx,yenivektory);
            return c;
        }
    }
}
