using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensj_InfoTest
{
    public class mensj_Disoccupato : mensj_Canditato
    {
        private int mensj_voto;
        private bool mensj_lode;

        public int Voto
        {
            get { return mensj_voto; }
            set
            {
                if (mensj_voto > 0 && mensj_voto <= 110)
                    mensj_voto = value;
                else
                    throw new Exception("voto non valido");
            }
    
        }
        public bool Lode
        {
            get { return mensj_lode; }
            set { mensj_lode = value; }
        }
        public mensj_Disoccupato()
        {
            Voto = 0;
            Lode = false;
        }
        public mensj_Disoccupato(int v,bool l)
        {
            Voto = v;
            Lode = l;          
        }
        public override int punteggio()
        {
            int vs = 0;
            vs = (Voto * 100) / 110;
            if (Lode == true)
                vs += 5;
            return vs;

        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
                return true;
            return false;
        }
    }
}
