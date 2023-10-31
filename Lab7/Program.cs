using System;

namespace Lab7
{
    //      Un POSl va accepta atat plata contactless cat si plata contact-full.Cele doua modalitati de plata vor fi modelate prin intermediul a doua metode, ce vor primi cate doi parametri:
    //        1. Suma de plata
    //        2. dispozitivul prin care se va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata.

    //      Pentru plata prin intermediul POS-ului, clientul va putea folosi atat:
    //       - carduri clasice – suporta doar plati contactfull;
    //       - carduri contactless - suporta atat plati contact-full cat si plati contactless;
    //       - telefoane mobile contactless - suporta doar plati contactless;

    //        Casa de marcat va oferi metode de plata cash sau prin intermediul unui POS.
    //        • In cazul platii cash, casa de marcat:
    //          1. va deschide un seif
    //          2. va introduce suma in seif
    //          3. va inchide seif-ul
    //          4. Va elibera chitanta
    //        • In cazul platii cu cardul, casa de marcat
    //          1. Va trimite POS-ului suma de plata
    //        ▪ Comunicarea cu POS-ul va fi realizata prin intermediul unei interfete
    //          2. va pune la dispozitia clientului POS-ul.
    //        ▪ Pos-ul pus la dispozitia clientului va avea “incarcata” suma de plata
    //        ▪ Clientul (functia main) va decide modalitatea de plata prin intermediul cardului (contactless/contactfull)

    class Program
    {
        static void Main(string[] args)
        {
            //Pentru plata prin intermediul POS - ului

            bool cardClasic = true;
            bool carduriContactless = false;
            bool telefoaneMobileContactless = false;

            double sumaDeplata = 0;

            IContactless contactless = new ContactlessClass();
            IContactFull contactFull = new ContactFullClass();

            if (cardClasic)
            {
                contactFull.PlataContactFull(sumaDeplata, contactFull);
            }

            if (carduriContactless)
            {
                contactFull.PlataContactFull(sumaDeplata, contactFull);
                contactless.PlataContactless(sumaDeplata, contactless);
            }

            if (telefoaneMobileContactless)
            {
                contactless.PlataContactless(sumaDeplata, contactless);
            }

            //ex2  Casa de marcat cash sau POS

            bool cash = false;

            ICash icash = new CashClass();

            if (cash)
            {
                icash.DeschideSeif();
                icash.IntroducereSuma();
                icash.InchideSeif();
                icash.ElibereazaChitanta();
                icash.PlataCash(sumaDeplata);
            }
            else
            {

                if (cardClasic)
                {
                    contactFull.PlataContactFull(sumaDeplata, contactFull);
                }

                if (carduriContactless)
                {
                    contactFull.PlataContactFull(sumaDeplata, contactFull);
                    contactless.PlataContactless(sumaDeplata, contactless);
                }

                if (telefoaneMobileContactless)
                {
                    contactless.PlataContactless(sumaDeplata, contactless);
                }

            }
        }
    }
}
