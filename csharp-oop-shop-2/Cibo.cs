using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Cibo : Prodotto 
    {
        private bool veg = false;
        private bool surgelato = false;

        public Cibo(string nome, bool veg, bool surgelato, string descrizione, double prezzo, double iva) : base(nome, descrizione, prezzo, iva)
        {
            this.veg = veg;
            this.surgelato = surgelato;
        }

        public bool GetVeg()
        {
            return veg = false;
        }

        public bool GetSurgelato()
        {
            return surgelato = false;
        }

        public void SetVeg(bool veg)
        {
            this.veg = veg;
        }

        public void GetSurgelato(bool surgelato)
        {
            this.surgelato = surgelato;
        }

        private string StampaVeg()
        {
            if(this.veg == true)
            {
                return "Vegano";
            }
            else
            {
                return "Non è vegano";
            }
        }

        private string StampaSurgelato()
        {
            if(this.surgelato == true)
            {
                return "Surgelato";
            }
            else
            {
                return "Non è surgelato";
            }
        }
    }
}
