using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensj_InfoTest
{
    public class mensj_Disoccupato : mensj_Canditato,IComparable<mensj_Disoccupato>,IEquatable<mensj_Disoccupato>
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
        public override string ToString()
        {
            return Matricola.ToString() + ";" + Nome + ";" + Voto.ToString()+";"+Lode.ToString();
        }
        public bool Equals(mensj_Disoccupato d)
        {
            if (d == null) return false;
            if (this == d) return true;

            return this.Matricola == d.Matricola && this.Nome == d.Nome && this.Voto==d.Voto && this.Lode == d.Lode;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is mensj_Disoccupato))
                return false;

            if (obj == null) return false;

            return this.Equals(obj);
        }
        public int CompareTo(mensj_Disoccupato d)
        {
            return this.punteggio().CompareTo(d.punteggio());
        }
        public override int GetHashCode() => (Matricola, Nome).GetHashCode();
    }
}
