using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.tcKimlikNo = "12375478656";
            Console.WriteLine(personel.tcKimlikNo);
            Console.ReadLine();
        }
    }
    class Personel
    {
        private string tckimlikno;
        public string tcKimlikNo
        {
            get
            {
                return tckimlikno.Substring(0,4)+"******";
            }
            set
            {
                bool kontrol = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                       bool sayiMi= char.IsNumber(value[i]);

                        if (sayiMi)
                        {

                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("Lütfen T.C kimlik numaranızda geçersiz karakter bulundurmayınız!");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                    
                }
                else
                {
                    Console.WriteLine("T.C kimlik no 11 karakter değil!");
                }
            }
        }
    }
}
