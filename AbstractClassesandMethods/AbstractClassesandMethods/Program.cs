using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesandMethods
{
    class Program
    {
        //abstract-->soyut
        //abstract methodlar abstract sınıflar içinde kullanılır!
        //doğrudan soyut class la ilgili obje oluşturamazsın!
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.SekilCiz();
            Console.ReadLine();
        }
    }
    abstract class Sekil
    {
        //class'ın orjinalinde şekilçiz'i kullanmayıp kalıtılanlarda kullanacaksam abstract!
        public abstract void SekilCiz(); //virtual yapınca içine doldurman lazım, abstract ta değil!
    }
    class Cember : Sekil
    {
        public override void SekilCiz() //abstract alırsan override etmek zorundasın!
        {
            Console.WriteLine("Çember çiziliyor!");
        }
    }
}
