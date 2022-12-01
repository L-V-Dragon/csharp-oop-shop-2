using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Liquido : Prodotto
    {
        private bool potabile = false;
        private bool gassata = false;

        public Liquido(string nome, bool potabile, bool gassata, string descrizione, double prezzo, double iva) : base(nome, descrizione, prezzo, iva)
        {
            this.potabile = potabile;
            this.gassata = gassata;
        }

        public bool GetPot()
        {
            return potabile = false;
        }

        public bool GetGassata()
        {
            return gassata = false;
        }

        public void SetTipo(bool potabile)
        {
            this.potabile = potabile;
        }

        public void SetGassata(bool gassata)
        {
            this.gassata = gassata;
        }

        public bool Pot()
        {
            return potabile = true;
        }

        private string StampaPot()
        {
            if (this.potabile == true)
            {
                return "Potabile";
            }
            else
            {
                return "Non è potabile";
            }
        }

        public bool Gas()
        {
            return this.gassata = true;
        }

        private string StampaGas()
        {
            if(this.gassata == true)
            {
                return "Gassato";
            }
            else
            {
                return "Non è gassato";
            }
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine(StampaPot());
            Console.WriteLine(StampaGas());
        }
    }
}
