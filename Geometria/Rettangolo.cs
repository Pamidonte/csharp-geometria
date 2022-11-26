using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {

        public string nomeRettangolo;
        public int baseRettangolo;
        public int altezzaRettangolo;
        public Rettangolo(int baser, int altezza, string nome) {

            nomeRettangolo = nome;
            baseRettangolo = baser;
            altezzaRettangolo= altezza;

        }
        public int calcoloArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }

        public int calcoloPerimetro()
        {
            return (baseRettangolo * 2) + (altezzaRettangolo * 2);
        }

        public void stampaRettangolo() {
            Console.WriteLine("-----" + this.nomeRettangolo + "-----");
            Console.WriteLine("\nbase " + this.baseRettangolo + " cm");
            Console.WriteLine("\naltezza " + this.altezzaRettangolo + " cm");
            Console.WriteLine("\nperimetro " + this.calcoloPerimetro() + " cm");
            Console.WriteLine("\narea " + this.calcoloArea() + " m^2");
            Console.WriteLine("-------------");



        }
      

    }
   




}
