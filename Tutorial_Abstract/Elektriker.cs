using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Abstract
{
    class Elektriker : Arbeiter
    {
        public override void ArbeitVerrichten()
        {
            //methods
            Console.WriteLine("Arbeit eines Elektrikers verrichten...");
        }
    }
}
