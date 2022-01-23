using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Kopek k1 = new Kopek();
            Kedi kedi1 = new Kedi();
            kedi1.yas = 13;
            k1.yas = 10;
            k1.ayaksayisi = 4;
            Console.WriteLine(k1.yas+" "+k1.ayaksayisi+" "+k1.Havla());
            Console.WriteLine(kedi1.yas+" "+kedi1.Miyavla());
            Console.ReadLine();
        }
    }

    class Hayvan
    {
        public int yas { get; set; }
    }

    class Kopek:Hayvan
    {
        public int ayaksayisi { get; set; }

        public string Havla()
        {
            return "Hav hav";
        }
    }
    class Kedi:Hayvan //extends şeklinde de yazabilir!
    {
        public string Miyavla()
        {
            return "Miyavv";
        }
    }
}
