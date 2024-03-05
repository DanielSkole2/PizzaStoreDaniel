using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDaniel
{
    public class Kunde
    {
        //her laver jeg en instans variabel kaldet _kundeid
        private int _kundeid;
        //her laver jeg en property kaldet 
        public int Kundeid
        {
            get { return _kundeid; }
        }

        private string _kundenavn;

        public string Kundenavn
        {
            get { return _kundenavn; }
        }

        private string _kontaktdetaljer;

        public string KontaktDetaljer
        {
            get { return _kontaktdetaljer; }
        }

        //Her laver jeg en constructor med parametre

        public Kunde(int kundeid, string kundenavn, string kontaktdetaljer)
        {
            _kundeid = kundeid;
            _kundenavn = kundenavn;
            _kontaktdetaljer = kontaktdetaljer;
        }
        // implement a ToString method
        public override string ToString()
        {
            return $"Kundenr: {_kundeid},Hedder: {_kundenavn},Adresse: {_kontaktdetaljer}";
        }


    }
}
