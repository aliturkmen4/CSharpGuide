using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        //abstract class la kullanımı aynı genelde interface kullanılır public yazmaya gerek kalmadığından!
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen();
            d1.SekilCiz();
            d1.Isim = "Ali";
            d1.Yas = 22;
            Console.WriteLine(d1.Isim+" "+d1.Yas);
            Console.ReadLine();
        }
    }
    public interface ISekil
    {
        int Yas { get; set; }
        string Isim { get; set; }
        void SekilCiz();
    }
    abstract class Sekil
    {
        public int Yas { get; set; }
        public string Isim { get; set; } //property
        public abstract void SekilCiz();
    }
    class Dikdortgen : Sekil
    {
        public override void SekilCiz()
        {
            Console.WriteLine("Dikdörtgen çizildi!");
        }
    }
    class Dıkdortgen : ISekil
    {
        public string Isim { get; set; }
        public int Yas { get; set; }

        //interface içinde field tanımlanamaz, property tanımlanır!

        public void SekilCiz()
        {
            Console.WriteLine("Dikdörtgen çiziliyor!");
        }
    }
}
//abstract property ve method oluşturmak istiyorsan abstract class kullanmak zorundasın!