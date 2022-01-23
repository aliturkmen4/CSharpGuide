using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedandSealedAccessProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //sealed-->mühürlü,tam korunmuş
            Ogrenci o1 = new Ogrenci("ali");
            Console.WriteLine(o1.isimsoyle());
            Console.ReadLine();
            //class'ın başına sealed yazarsan bu class'ı kimse miras alamaz!!!!
        }
    }
   /*sealed*/ class Kisiler //base class-->temel(ana)class
         {
        protected string isim { get; set; } //sadece kişileri miras alan sınıf tarafından kullanılabilir!
          }

    class Ogrenci : Kisiler //derived or child class-->türemiş sınıf (kalıtım alan)
    {
        public Ogrenci(string i)
        {
            this.isim = i;
        }
        public string isimsoyle()
        {
            return isim;
        }
    }
}
