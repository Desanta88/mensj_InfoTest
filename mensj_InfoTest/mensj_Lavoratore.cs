using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensj_InfoTest
{
    public class mensj_Lavoratore:mensj_Canditato
    {
        private int mensj_esperienze;
        public int Esperienze
        {
            get { return mensj_esperienze; }
            set
            {
                if (mensj_esperienze >= 0 && mensj_esperienze <= 5)
                    mensj_esperienze = value;
                else
                    throw new Exception("numero di esperienze non valide");
            }
        }
        public mensj_Lavoratore()
        {
            Esperienze = 0;
        }
        public mensj_Lavoratore(int e)
        {
            Esperienze = e;
        }
        public override int punteggio()
        {
            int vs=0;
            vs = Esperienze * 20;
            return vs;
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
                return true;
            return false;
        }
    }
}
