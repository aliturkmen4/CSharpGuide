using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolcu ilkOnluGrup = new Futbolcu();
            ilkOnluGrup[0] = "Ali";
            ilkOnluGrup[1] = "Resul";
            ilkOnluGrup[2] = "Emin";
            ilkOnluGrup[3] = "Neslihan";
            ilkOnluGrup[4] = "Sinem";
            ilkOnluGrup[5] = "Deniz";

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ilkOnluGrup[i]);
            }
            Console.ReadLine();
        }
    }
    class Futbolcu
    {
        string[] futbolcular = new string[10];
        //futbolcuların isimlerini tutacağım!

        public string this[int index] 
        {
            get { return futbolcular[index]; }
            set { futbolcular[index] = value; }
        }
    }
}
