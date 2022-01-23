using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Property_Auto_Implemented_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan("erkek");
            i1.Isim = "Ali Türkmen"; //"Ali Türkmen"--> set teki value değerine atandı!
            i1.Yas = 25;
            //i1.Cinsiyet = "erkek";
            Console.WriteLine(i1.Isim+" "+i1.Yas+" "+i1.Cinsiyet);
            Console.ReadLine();
        }
    }
    class Insan
    {
        private string isim; //field(alan)
        public string Isim //property-mülk
        {
            get { return isim; }
            set { isim = value; }
        }
        private int yas;

        public int Yas //property-mülk
        {
            get { return yas; }
            set { if(value>=0) yas = value; }
        }

        private string cinsiyet;

        public Insan(string cinsiyet)
        {
            this.Cinsiyet = cinsiyet;
        }
        public string Cinsiyet //read-only
        {
            get ;   
        }

    }
}