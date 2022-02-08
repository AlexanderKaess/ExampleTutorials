using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_9
{
    //Klasse AutoIDInfo "hat eine" Beziehung zu Klasse Auto
    class AutoIDInfo
    {
        //variables

        //properties
        //muss public sein damit von aussen (von Klasse Auto) darauf zugegriffen werden kann
        public int IDNum { get; set; } = 0;
        public string Besitzer { get; set; } = "Kein Besitzer";

    }
}
