using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Liquido : Prodotto
    {
        private string tipo = "";
        private bool gassata = false;

        public Liquido(string nome, string tipo, bool gassata, string descrizione, double prezzo, double iva) : base(nome, descrizione, prezzo, iva)
        {
            this.tipo = tipo;
            this.gassata = gassata;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public bool GetGassata()
        {
            return gassata = false;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void SetGassata(bool gassata)
        {
            this.gassata = gassata;
        }

        public bool Gas()
        {
            return this.gassata = true;
        }

        private string StampaGas()
        {
            if(this.gassata == true)
            {
                return "Gassata";
            }
            else
            {
                return "Non è gassata";
            }
        }
    }
}
