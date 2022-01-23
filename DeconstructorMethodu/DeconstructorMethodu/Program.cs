using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructorMethodu
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            ObjeleriOlustur();
            GC.Collect(); // main içerisinde kullanılmayanları çöpe attım!(i2'yi)
            Console.ReadLine();
        }
        static void ObjeleriOlustur()
        {         
            Insan i2 = new Insan();
        }
    }
    class Insan
    {
        public string isim;

        public Insan()
        {
            Console.WriteLine("İnsan oluşturuldu.");
        }
        ~Insan()
        {
            Console.WriteLine("Obje yok oldu!"); 
        }   
    }
}
