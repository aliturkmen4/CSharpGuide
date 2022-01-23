using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Virtual_Override
{
    class Program
    {
        //polymorphism-->birden fazla formun oluşma durumu
        static void Main(string[] args)
        {
            Sekil s1 = new Sekil();
            Dikdortgen d1 = new Dikdortgen();
            Cember c1 = new Cember();
            c1.SekilCiz();
            d1.SekilCiz();
            s1.SekilCiz();
            Console.ReadLine();
        }
    }
    class Sekil
    {
        public virtual void SekilCiz() //virtual-->sanal //kalıtım alınacak classta uygulanır!
        {
            Console.WriteLine("Şekil çiziliyor.");
        }
    }
    class Dikdortgen : Sekil
    {
        public override void SekilCiz() //override-->geçersiz kılmak //Override yaparak base classtaki şekil çiziliyor'u geçersiz kıldım!
        {
            Console.WriteLine("Didörtgen çiziliyor.");
        }
    }
    class Cember : Sekil
    {
        public override void SekilCiz()
        {
            Console.WriteLine("Çember çiziliyor.");
        }
    }
}
