using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Interfaces
{
    interface ITier
    {
        //properties
        int Alter { get; set; }
        string Geschlecht { get; set; }

        //methods
        void Essen();
        void Trinken();
    }
}
