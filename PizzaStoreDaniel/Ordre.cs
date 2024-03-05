using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDaniel
{
    public class Ordre
    {
        //her laver jeg en instans variabel kaldet _ordreid
        private int _ordreid;
        //her laver jeg en property kaldet Ordreid
        public int Ordreid
        {
            get { return _ordreid; }
        }


        private int _kundeid;
        public int Kundeid
        {
            get { return _kundeid; }
        }

        private int _totalbeloeb;

        public int Totalbeloeb
        {
            get { return _totalbeloeb; }
        }

        //Her laver jeg en constructor med parametre
        public Ordre(int ordreid, int kundeid, int totalbeloeb)
        {
            _ordreid = ordreid;
            _kundeid = kundeid;
            _totalbeloeb = totalbeloeb;

        }
        // implement a ToString method
        public override string ToString()
        {
            return $"Ordre nr: {_ordreid},Kunde nr: {_kundeid},Subtotal: {_totalbeloeb}";
        }

        //Jeg ville gerne lave en funktion kaldet CalculateTotalPrice, som skal beregne samlede pris
        public int CalculateTotalPrice()
        {
            //Moms er 25% af Subtotal'en 
            double momsRate = 0.25;
            int momsTotal = (int)(_totalbeloeb * momsRate);

            //Deliveringcost 
            int delivercost = 40;

            //Total price ville blive calculated sådan her
            int totalPrice = _totalbeloeb + momsTotal + delivercost;

            return totalPrice;

        }

    }
}
