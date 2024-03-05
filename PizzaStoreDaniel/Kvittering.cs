using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDaniel
{
    public class Kvittering
    {

        //her laver jeg en instans variabel kaldet _totalbeløb
        private int _totalbeloeb;
        //her laver jeg en property kaldet Totalbeløb
        public int Totalbeloeb
        {
            get { return _totalbeloeb; }
        }

        private string _kvitteringbeskrivelse;

        public string Kvitteringbeskrivelse
        {
            get { return _kvitteringbeskrivelse; }
        }


        //Her laver jeg en constructor med parametre

        public Kvittering(string kvitteringbeskrivelse, int totalbeloeb)
        {
            _kvitteringbeskrivelse = kvitteringbeskrivelse;
            _totalbeloeb = totalbeloeb;
        }
        // implement a ToString method
        public override string ToString()
        {
            return $"Du har købt: {_kvitteringbeskrivelse},Subtotal: {_totalbeloeb}";
        }




    }
}
