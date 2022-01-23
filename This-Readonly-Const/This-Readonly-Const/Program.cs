using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Readonly_Const
{
    class Program
    {
        static void Main(string[] args)
        {
            Isci i1 = new Isci(2020.5);
            Isci i2 = new Isci(4040.8);
            Console.WriteLine(i1.maas+" "+i2.maas);
            
            //readonly constructor içerisinde değiştirilebilir!(consttan farkı)
            /*readonly sabitine sonradan değer atanabilir!(consttan farkı)
            const sabitinin değeri oluşturulduğu anda verilmek zorundadır!*/
            //readonly matematiksel işlemlerin sonunda değerine kavuşabilir ama const ulaşamaz!
            Console.ReadLine();
        }
    }
    class Isci
    {
       public readonly double maas; //değiştirilemez.
        public Isci(double salary)
        {
            this.maas = salary;
        }
        readonly double mutA = Math.Abs(-1);
        //const double mutB = Math.Abs(-5);
    }
}
