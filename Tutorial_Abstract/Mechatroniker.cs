using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Abstract
{
    class Mechatroniker : Arbeiter
    {
        //methods
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Mechatroniker verrichtet die schwerste Arbeit..");
        }
    }
}
