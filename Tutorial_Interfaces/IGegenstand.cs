using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Interfaces
{
    interface IGegenstand
    {
        //properties
        int Goldwert { get; set; }
        string Name { get; set; }

        //methods
        void Benutzen();
        void Verkaufen();

    }
}
