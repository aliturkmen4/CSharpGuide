using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Yapici_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan("Ali Türkmen",25);          
            i2.BilgileriSoyle();
            Console.ReadLine();
        }
    }
    class Insan
    {
        string isim;
        int yas;

        public Insan() //constructor method kısmı
        {
            Console.WriteLine("Yeni bir insan objesi oluşturuldu!");
        }

        public Insan(string name,int yas)
        {
            this.isim = name;
            this.yas = yas;
        }

        public void BilgileriSoyle()
        {
            Console.WriteLine("Adım: {0}, Yaşım:{1}",isim,yas);
        }
    }
}
