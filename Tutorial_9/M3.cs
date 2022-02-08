using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_9
{
    class M3 : Bmw
    {
        //variables

        //properties

        //default constructor
        public M3()
        {
            PS = 0;
            Farbe = "KEINE";
            Model = "KEIN";
        }

        //constructor
        public M3(string model, int ps, string farbe) : base(model ,ps, farbe)
        {

        }

        //methods
        //sealed = versiegelt methode, 
        //durch sealed kann methode in abgeleiter Klasse nicht überschrieben (override) werden
        public override void ReparaturAuto()
        {
            base.ReparaturAuto();
        }

    }
}
