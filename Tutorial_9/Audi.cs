using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_9
{
    class Audi : Auto
    {
        //variables
        private string marke = "Audi";

        //properties
        protected string Model { get; set; }

        //default constructor
        public Audi()
        {
            PS = 0;
            Farbe = "KEINE";
            Model = "KEIN";
        }

        //constructor
        public Audi(string model, int ps, string farbe) : base(ps, farbe)
        {
            this.Model = model;
        }

        //methods
        public override void ZeigeDetails()
        {
            Console.WriteLine("Marke: {0} mit Model: {1} hat {2} PS und die Farbe {3}",this.marke, this.Model, this.PS, this.Farbe);
        }

        public override void ReparaturAuto()
        {
            Console.WriteLine("Das {0} {1} wurde repariert", this.marke, this.Model);
        }


    }
}
