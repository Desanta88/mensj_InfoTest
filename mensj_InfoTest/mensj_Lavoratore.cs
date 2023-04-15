using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensj_InfoTest
{
    public class mensj_Lavoratore: mensj_Canditato,IComparable<mensj_Lavoratore>,IEquatable<mensj_Lavoratore>
    {
        private int mensj_esperienze;
        public int Esperienze
        {
            get { return mensj_esperienze; }
            set
            {
                if ( mensj_esperienze >= 0 && mensj_esperienze <= 5 )

                    mensj_esperienze = value;

                else

                    throw new Exception("numero di esperienze non valide");
            }
        }
        public mensj_Lavoratore()
        {
            Esperienze = 0;
        }
        public mensj_Lavoratore(int m,string n,int e)
        {
            Matricola = m;
            Nome = n;
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
            if ( punteggio() >= 60 )

                return true;

            return false;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + Nome + ";" + Esperienze.ToString();
        }
        public bool Equals(mensj_Lavoratore l)
        {
            if ( l == null ) return false;
            if ( this == l ) return true;

            return base.Equals(l) && this.Esperienze == l.Esperienze;
        }
        public override bool Equals(object obj)
        {
            if ( !(obj is mensj_Lavoratore) )
                return false;

            if ( obj == null ) return false;

            return this.Equals(obj);
        }
        public int CompareTo(mensj_Lavoratore l)
        {
            return this.punteggio().CompareTo(l.punteggio());
        }

        public override int GetHashCode() => (Matricola, Nome).GetHashCode();
    }
}
