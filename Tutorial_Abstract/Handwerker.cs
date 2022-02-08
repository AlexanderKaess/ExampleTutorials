using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Abstract
{
    class Handwerker : Arbeiter
    {
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Handwerker verrichtet etwas anderes");
        }
    }
}
