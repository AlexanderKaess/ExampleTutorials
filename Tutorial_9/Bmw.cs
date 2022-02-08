using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_9
{
    //durch sealed kann Klasse nicht abgeleitet werden
    //sealed class Bmw : Auto
    class Bmw : Auto
    {
        //variables
        private string marke = "Bmw";

        //properties
        protected string Model { get; set; }

        //default constructor
        public Bmw()
        {
            PS = 0;
            Farbe = "KEINE";
            Model = "KEIN";
        }

        //constructor
        public Bmw(string model, int ps, string farbe) : base(ps,farbe)
        {
            this.Model = model;
        }

        //methods
        public override void ZeigeDetails()
        {
            Console.WriteLine("Marke: {0} mit Model: {1} hat {2} PS und die Farbe {3}", this.marke, this.Model, this.PS, this.Farbe);
        }

        //sealed = versiegelt methode, 
        //durch sealed kann methode in abgeleiter Klasse nicht überschrieben (override) werden
        //public sealed override void ReparaturAuto()
        public override void ReparaturAuto()

        {
            Console.WriteLine("Das {0} {1} wurde repariert", this.marke, this.Model);
        }

    }
}
