using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    interface IContactFull
    {
        public void Introduce();
        public void EfectueazaPlata();
        public void Extrage();
        void PlataContactFull(double sumaDeplata, IContactFull contactFull);
    }

    class ContactFullClass : IContactFull
    {
        void IContactFull.Introduce() 
        {
            Console.WriteLine("Puteti sa introduceti cardul!");
        }
        void IContactFull.EfectueazaPlata() 
        {
            Console.WriteLine("Puteti sa efectuati plata!");
        }
        void IContactFull.Extrage() 
        {
            Console.WriteLine("Puteti sa extrageti banii!");
        }
        void IContactFull.PlataContactFull(double sumaDeplata, IContactFull contactFull) 
        {
            contactFull.Introduce();
            contactFull.EfectueazaPlata();
            contactFull.Extrage();

            Console.WriteLine("Ati achitat: " + sumaDeplata);
        }
    }
}