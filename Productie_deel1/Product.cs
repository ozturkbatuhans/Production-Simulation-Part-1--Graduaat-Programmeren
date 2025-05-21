using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productie_deel1
{
    public class Product
    {
        private string _sNaam;
        private int _iHoeveelheid;

        public Product(string naam, int hoeveelheid)
        {
            _sNaam = naam;
            _iHoeveelheid = hoeveelheid;
        }

        public string Gegevens()
        {
            return $"Product: {_sNaam} - Hoeveelheid: {_iHoeveelheid}";
        }

        public string Naam
        {
            get { return _sNaam; }
        }
    }
}
