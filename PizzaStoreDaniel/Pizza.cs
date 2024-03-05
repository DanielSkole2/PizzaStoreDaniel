using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDaniel
{
    public class Pizza
    {
        //her laver jeg en instans variabel kaldet _pizzaid
        private int _pizzaID;
        //her laver jeg en property called PizzaID
        public int PizzaID
        {
            get { return _pizzaID; }
        }

        private string _pizzanavn;

        public string Pizzanavn
        {
            get { return _pizzanavn; }
        }

        private string _pizzabeskrivelse;

        public string Pizzabeskrivelse
        {
            get { return _pizzabeskrivelse; }
        }

        public int _pizzapris;
        public int Pizzapris
        {
            get { return _pizzapris; }
        }
        //Her laver jeg en constructor med parametre
        public Pizza(int pizzaID, string Pizzanavn, string Pizzabeskrivelse, int pizzapris)
        {
            _pizzaID = pizzaID;
            _pizzanavn = Pizzanavn;
            _pizzabeskrivelse = Pizzabeskrivelse;
            _pizzapris = pizzapris;
        }
        // implement a ToString method
        public override string ToString()
        {
            return $"Pizza ID: {_pizzaID}, Pizza navn: {_pizzanavn},Indeholder: {_pizzabeskrivelse},Pizza pris: {_pizzapris}";

        }


    }
}
