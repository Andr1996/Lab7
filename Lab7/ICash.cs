using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    interface ICash
    {
        public void DeschideSeif();
        public void IntroducereSuma();
        public void InchideSeif();
        public void ElibereazaChitanta();

        void PlataCash(double sumaDeplata);
    }
    class CashClass : ICash
    { 
        void ICash.DeschideSeif()
        {
            Console.WriteLine("Deschidere seif.");
        }
        void ICash.IntroducereSuma()
        {
            Console.WriteLine("Introducerea sumei in seif.");
        }
        void ICash.InchideSeif()
        {
            Console.WriteLine("Inchidere seif.");
        }
        void ICash.ElibereazaChitanta()
        {
            Console.WriteLine("Eliberare chitanta.");
        }
        void ICash.PlataCash(double sumaDeplata)
        {
            Console.WriteLine("Ati achitat: " + sumaDeplata);
        }
    }
}
