using System;
using System.Collections.Generic;
using System.Text;

namespace AS2122_INF_4E_MolinoFederico_ProvaSingola
{
    class Articolo
    {
        string codice;
        string descrizione;
        string unitàDiMisura;
        string prezzo;

      public Articolo(string codice, string descrizione, string unitàDiMisura, string prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitàDiMisura = unitàDiMisura;
            this.prezzo = prezzo;
        }
        public string Codice { get { return codice; } }
        public string Descrizione { get { return descrizione; } }
        public string UnitàdiMisura { get { return unitàDiMisura; } }
        public double Prezzo { get { return Prezzo; } }
    }
}
