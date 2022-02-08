using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_9
{
    class Auto
    {
        //variables

        //properties
        protected int PS { get; set; }
        protected string Farbe { get; set; }

        //"Hat eine" Beziehung
        //Objekt Komposition = Objetkt in einer anderen Klasse instanzieren
        AutoIDInfo autoIDInfo = new AutoIDInfo();

        //default constructor
        public Auto()
        {
            PS = 0;
            Farbe = "KEINE";
        }

        //constructor
        public Auto(int ps, string farbe)
        {
            this.PS = ps;
            this.Farbe = farbe;
        }

        //methods
        public virtual void ZeigeDetails()
        {
            Console.WriteLine("Das Auto hat {0} PS und die Farbe {1}", this.PS, this.Farbe);
        }

        public virtual void ReparaturAuto()
        {
            Console.WriteLine("Das Auto wurde repariert");
        }

        //"Hat eine" Beziehung
        public void SetAutoIDInfo(int iDNum, string besitzer)
        {
            autoIDInfo.IDNum = iDNum;
            autoIDInfo.Besitzer = besitzer;
        }

        public void GetAutoIDInfo()
        {
            Console.WriteLine("Das Auto hat die ID {0} und den Beseitzer {1}", autoIDInfo.IDNum, autoIDInfo.Besitzer); ;
        }

    }
}
