using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    interface IContactless
    {
        public void Apropie();
        public void EfectueazaPlata();

        void PlataContactless(double sumaDeplata, IContactless contactless);
    }

    class ContactlessClass : IContactless
    {
        void IContactless.Apropie() 
        {
            Console.WriteLine("Apropiati cardul!");
        }
        void IContactless.EfectueazaPlata()
        {
            Console.WriteLine("Puteti sa efectuati plata!");
        }
        void IContactless.PlataContactless(double sumaDeplata, IContactless contactless)
        {
            contactless.Apropie();
            contactless.EfectueazaPlata();

            Console.WriteLine("Ati achitat: " + sumaDeplata);
        }
    }
}
