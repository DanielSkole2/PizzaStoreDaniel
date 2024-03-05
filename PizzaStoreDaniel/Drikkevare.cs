using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDaniel
{
    public class Drikkevare
    {
        //her laver jeg en instans variabel kaldet _drikkevareid
        private int _drikkevareid;

        //her laver jeg en property called DrikkevareID
        public int DrikkevareID
        {
            get { return _drikkevareid; }
        }

        private string _drikkevarenavn;
        public string DrikkevareNavn
        {
            get { return _drikkevarenavn; }
        }

        private int _drikkevarepris;
        public int Drikkevarepris
        {
            get { return _drikkevarepris; }
        }

        //Her laver jeg en constructor med 3 parametre
        public Drikkevare(int drikkevareid, string drikkevarenavn, int drikkevarepris)
        {
            _drikkevareid = drikkevareid;
            _drikkevarenavn = drikkevarenavn;
            _drikkevarepris = drikkevarepris;

        }

        // implement a ToString method
        public override string ToString()
        {
            return $"Drikkevare ID: {_drikkevareid}, drikkevare navn: {_drikkevarenavn}, drikkevarepris: {_drikkevarepris}";
        }





    }
}
